using PureFix.Types;
using PureFix.Types.Config;
using Serilog;
using Serilog.Events;

namespace TradeCaptureDemo.Support;

public class ConsoleLogFactory : ILogFactory
{
    private readonly Serilog.ILogger _appLogger;
    private readonly Serilog.ILogger _plainLogger;

    public ConsoleLogFactory(ISessionDescription? description = null, string? logDir = null)
    {
        var appConfig = new LoggerConfiguration()
            .MinimumLevel.Information()
            .Enrich.WithThreadId()
            .WriteTo.Console(outputTemplate: "[{Timestamp:HH:mm:ss.fff}] [{Level:u3}] [{ThreadId}] {Message}{NewLine}{Exception}");

        var plainConfig = new LoggerConfiguration()
            .MinimumLevel.Information()
            .WriteTo.Console(outputTemplate: "{Message}{NewLine}");

        if (logDir != null)
        {
            Directory.CreateDirectory(logDir);
            var timestamp = DateTime.Now.ToString("yyyyMMdd-HHmmss");

            // App log file
            appConfig.WriteTo.File(
                Path.Combine(logDir, $"app-{timestamp}.log"),
                outputTemplate: "[{Timestamp:HH:mm:ss.fff}] [{Level:u3}] [{ThreadId}] {Message}{NewLine}{Exception}");

            // FIX message log file (plain)
            plainConfig.WriteTo.File(
                Path.Combine(logDir, $"fix-{timestamp}.log"),
                outputTemplate: "{Message}{NewLine}");
        }

        _appLogger = appConfig.CreateLogger();
        _plainLogger = plainConfig.CreateLogger();
    }

    public PureFix.Types.ILogger MakeLogger(string name)
    {
        return new SerilogWrapper(_appLogger.ForContext("Name", name));
    }

    public PureFix.Types.ILogger MakePlainLogger(string name)
    {
        return new SerilogWrapper(_plainLogger.ForContext("Name", name));
    }

    private class SerilogWrapper : PureFix.Types.ILogger
    {
        private readonly Serilog.ILogger _logger;

        public SerilogWrapper(Serilog.ILogger logger) => _logger = logger;

        public void Debug(string message) => _logger.Debug(message);
        public void Error(string message) => _logger.Error(message);
        public void Error(Exception ex) => _logger.Error(ex, ex.Message);
        public void Error(Exception ex, string message) => _logger.Error(ex, message);
        public void Info(string message) => _logger.Information(message);
        public void Warn(string message) => _logger.Warning(message);
    }
}

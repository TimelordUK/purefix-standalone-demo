using PureFix.Types;
using PureFix.Types.Config;
using Serilog;
using Serilog.Events;

namespace TradeCaptureDemo.Support;

public class ConsoleLogFactory : ILogFactory
{
    private readonly Serilog.ILogger _appLogger;
    private readonly Serilog.ILogger _plainLogger;

    public ConsoleLogFactory(ISessionDescription? description = null)
    {
        // App logger - with timestamps and thread info
        _appLogger = new LoggerConfiguration()
            .MinimumLevel.Information()
            .Enrich.WithThreadId()
            .WriteTo.Console(outputTemplate: "[{Timestamp:HH:mm:ss.fff}] [{Level:u3}] [{ThreadId}] {Message}{NewLine}{Exception}")
            .CreateLogger();

        // FIX message logger - plain output
        _plainLogger = new LoggerConfiguration()
            .MinimumLevel.Information()
            .WriteTo.Console(outputTemplate: "{Message}{NewLine}")
            .CreateLogger();
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

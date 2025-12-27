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
            .MinimumLevel.Debug()
            .Enrich.WithThreadId()
            .WriteTo.Console(outputTemplate: "[{Timestamp:HH:mm:ss.fff}] [{Level:u3}] [{ThreadId}] {Message:lj}{NewLine}{Exception}");

        var plainConfig = new LoggerConfiguration()
            .MinimumLevel.Debug()
            .WriteTo.Console(outputTemplate: "{Message:lj}{NewLine}");

        if (logDir != null)
        {
            Directory.CreateDirectory(logDir);
            var timestamp = DateTime.Now.ToString("yyyyMMdd-HHmmss");

            // App log file
            appConfig.WriteTo.File(
                Path.Combine(logDir, $"app-{timestamp}.log"),
                outputTemplate: "[{Timestamp:HH:mm:ss.fff}] [{Level:u3}] [{ThreadId}] {Message:lj}{NewLine}{Exception}");

            // FIX message log file (plain)
            plainConfig.WriteTo.File(
                Path.Combine(logDir, $"fix-{timestamp}.log"),
                outputTemplate: "{Message:lj}{NewLine}");
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

    private sealed class SerilogWrapper(Serilog.ILogger logger) : PureFix.Types.ILogger
    {
        public bool IsEnabled(LogLevel level) => logger.IsEnabled(ToSerilog(level));

        public void Debug(string message) => logger.Debug(message);
        public void Debug<T>(string template, T arg) => logger.Debug(template, arg);
        public void Debug<T1, T2>(string template, T1 arg1, T2 arg2) => logger.Debug(template, arg1, arg2);
        public void Debug<T1, T2, T3>(string template, T1 arg1, T2 arg2, T3 arg3) => logger.Debug(template, arg1, arg2, arg3);

        public void Info(string message) => logger.Information(message);
        public void Info<T>(string template, T arg) => logger.Information(template, arg);
        public void Info<T1, T2>(string template, T1 arg1, T2 arg2) => logger.Information(template, arg1, arg2);
        public void Info<T1, T2, T3>(string template, T1 arg1, T2 arg2, T3 arg3) => logger.Information(template, arg1, arg2, arg3);

        public void Warn(string message) => logger.Warning(message);
        public void Warn<T>(string template, T arg) => logger.Warning(template, arg);
        public void Warn<T1, T2>(string template, T1 arg1, T2 arg2) => logger.Warning(template, arg1, arg2);
        public void Warn<T1, T2, T3>(string template, T1 arg1, T2 arg2, T3 arg3) => logger.Warning(template, arg1, arg2, arg3);

        public void Error(string message) => logger.Error(message);
        public void Error(Exception ex) => logger.Error(ex, ex.Message);
        public void Error(Exception ex, string? message = null) => logger.Error(ex, message ?? ex.Message);
        public void Error<T>(Exception ex, string template, T arg) => logger.Error(ex, template, arg);
        public void Error<T1, T2>(Exception ex, string template, T1 arg1, T2 arg2) => logger.Error(ex, template, arg1, arg2);

        private static LogEventLevel ToSerilog(LogLevel level) => level switch
        {
            LogLevel.Debug => LogEventLevel.Debug,
            LogLevel.Info => LogEventLevel.Information,
            LogLevel.Warn => LogEventLevel.Warning,
            LogLevel.Error => LogEventLevel.Error,
            _ => LogEventLevel.Information
        };
    }
}

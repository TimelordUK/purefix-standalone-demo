using Microsoft.Extensions.Configuration;
using PureFix.Types;
using PureFix.Types.Config;
using Serilog;
using Serilog.Events;

namespace TradeCaptureDemo.Infrastructure;

public class ConsoleLogFactory : ILogFactory
{
    private readonly Serilog.ILogger _appLogger;
    private readonly Serilog.ILogger _plainLogger;
    private readonly string _session;

    public ConsoleLogFactory(ISessionDescription? description = null, string? logDir = null)
    {
        // Use SenderCompID as the session identifier for log output
        _session = description?.SenderCompID ?? description?.Application?.Name ?? "app";

        // Try to load configuration from appsettings.json
        var configPath = Path.Combine(AppContext.BaseDirectory, "appsettings.json");
        IConfiguration? configuration = null;

        if (File.Exists(configPath))
        {
            configuration = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: false)
                .Build();
        }

        // Build the app logger (either from config or programmatic)
        _appLogger = BuildAppLogger(configuration, logDir);

        // Build the plain logger for FIX message output
        _plainLogger = BuildPlainLogger(configuration, logDir);
    }

    private Serilog.ILogger BuildAppLogger(IConfiguration? configuration, string? logDir)
    {
        LoggerConfiguration loggerConfig;

        if (configuration != null)
        {
            // Load from appsettings.json
            loggerConfig = new LoggerConfiguration()
                .ReadFrom.Configuration(configuration)
                .Enrich.WithProperty("Session", _session);
        }
        else
        {
            // Fall back to programmatic configuration
            loggerConfig = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .Enrich.WithThreadId()
                .Enrich.WithProperty("Session", _session)
                .WriteTo.Console(
                    outputTemplate: "[{Timestamp:HH:mm:ss.fff}] [{Level:u3}] [{ThreadId,2}] [{Session,-12}] {Message:lj}{NewLine}{Exception}");
        }

        // Add file sink if logDir specified (overrides config)
        var effectiveLogDir = logDir ?? configuration?.GetValue<string>("Logging:LogDir");
        if (!string.IsNullOrEmpty(effectiveLogDir))
        {
            Directory.CreateDirectory(effectiveLogDir);

            var fileTemplate = configuration?.GetValue<string>("Logging:FileOutputTemplate")
                ?? "[{Timestamp:HH:mm:ss.fff}] [{Level:u3}] [{ThreadId,2}] [{Session,-12}] {Message:lj}{NewLine}{Exception}";

            loggerConfig.WriteTo.File(
                Path.Combine(effectiveLogDir, $"{_session}-app-.log"),
                outputTemplate: fileTemplate,
                rollingInterval: RollingInterval.Day,
                retainedFileCountLimit: null);
        }

        return loggerConfig.CreateLogger();
    }

    private Serilog.ILogger BuildPlainLogger(IConfiguration? configuration, string? logDir)
    {
        var plainTemplate = configuration?.GetValue<string>("Logging:PlainOutputTemplate")
            ?? "{Message:lj}{NewLine}";

        var loggerConfig = new LoggerConfiguration()
            .MinimumLevel.Debug()
            .WriteTo.Console(outputTemplate: plainTemplate);

        // Add file sink if logDir specified
        var effectiveLogDir = logDir ?? configuration?.GetValue<string>("Logging:LogDir");
        if (!string.IsNullOrEmpty(effectiveLogDir))
        {
            Directory.CreateDirectory(effectiveLogDir);

            loggerConfig.WriteTo.File(
                Path.Combine(effectiveLogDir, $"{_session}-fix-.log"),
                outputTemplate: plainTemplate,
                rollingInterval: RollingInterval.Day,
                retainedFileCountLimit: null);
        }

        return loggerConfig.CreateLogger();
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
        public void DebugV(string template, params object?[] args) => logger.Debug(template, args);

        public void Info(string message) => logger.Information(message);
        public void Info<T>(string template, T arg) => logger.Information(template, arg);
        public void Info<T1, T2>(string template, T1 arg1, T2 arg2) => logger.Information(template, arg1, arg2);
        public void Info<T1, T2, T3>(string template, T1 arg1, T2 arg2, T3 arg3) => logger.Information(template, arg1, arg2, arg3);
        public void InfoV(string template, params object?[] args) => logger.Information(template, args);

        public void Warn(string message) => logger.Warning(message);
        public void Warn<T>(string template, T arg) => logger.Warning(template, arg);
        public void Warn<T1, T2>(string template, T1 arg1, T2 arg2) => logger.Warning(template, arg1, arg2);
        public void Warn<T1, T2, T3>(string template, T1 arg1, T2 arg2, T3 arg3) => logger.Warning(template, arg1, arg2, arg3);
        public void WarnV(string template, params object?[] args) => logger.Warning(template, args);

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

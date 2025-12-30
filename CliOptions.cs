using System.CommandLine;
using System.CommandLine.Binding;

namespace TradeCaptureDemo;

/// <summary>
/// Command-line options for the PureFix Trade Capture Demo.
/// All CLI arguments and options are defined here in one place.
/// </summary>
public class CliOptions
{
    // ─────────────────────────────────────────────────────────────────────────
    // Arguments
    // ─────────────────────────────────────────────────────────────────────────

    /// <summary>
    /// Operating mode: reset, recovery, broker-reset, clear
    /// </summary>
    public string Mode { get; set; } = "reset";

    // ─────────────────────────────────────────────────────────────────────────
    // Session Options
    // ─────────────────────────────────────────────────────────────────────────

    /// <summary>
    /// Run client (initiator) only
    /// </summary>
    public bool Client { get; set; }

    /// <summary>
    /// Run server (acceptor) only
    /// </summary>
    public bool Server { get; set; }

    /// <summary>
    /// Skeleton mode - no app messages, only heartbeats (for GC baseline testing)
    /// </summary>
    public bool Skeleton { get; set; }

    /// <summary>
    /// Custom config file path (for --client or --server)
    /// </summary>
    public string? Config { get; set; }

    // ─────────────────────────────────────────────────────────────────────────
    // Store Options
    // ─────────────────────────────────────────────────────────────────────────

    /// <summary>
    /// Use file store in specified directory
    /// </summary>
    public string? Store { get; set; }

    /// <summary>
    /// Read and display file store state, then exit without starting session
    /// </summary>
    public bool DryRun { get; set; }

    /// <summary>
    /// Truncate sender sequence number to specified value (use with --client and --store)
    /// </summary>
    public int? TruncateSeq { get; set; }

    // ─────────────────────────────────────────────────────────────────────────
    // Runtime Options
    // ─────────────────────────────────────────────────────────────────────────

    /// <summary>
    /// Enable file logging to logs/ directory
    /// </summary>
    public bool Log { get; set; }

    /// <summary>
    /// Exit after specified number of seconds
    /// </summary>
    public int? Timeout { get; set; }

    // ─────────────────────────────────────────────────────────────────────────
    // Computed Properties
    // ─────────────────────────────────────────────────────────────────────────

    public string? LogDir => Log ? Path.Join(AppContext.BaseDirectory, "logs") : null;

    // ─────────────────────────────────────────────────────────────────────────
    // CLI Configuration
    // ─────────────────────────────────────────────────────────────────────────

    /// <summary>
    /// Creates and configures the root command with all options.
    /// </summary>
    public static RootCommand CreateRootCommand()
    {
        var rootCommand = new RootCommand("PureFix Standalone Trade Capture Demo - FIX engine demonstration with GC monitoring");

        // Argument
        rootCommand.AddArgument(ModeArg);

        // Session options
        rootCommand.AddOption(ClientOption);
        rootCommand.AddOption(ServerOption);
        rootCommand.AddOption(SkeletonOption);
        rootCommand.AddOption(ConfigOption);

        // Store options
        rootCommand.AddOption(StoreOption);
        rootCommand.AddOption(DryRunOption);
        rootCommand.AddOption(TruncateSeqOption);

        // Runtime options
        rootCommand.AddOption(LogOption);
        rootCommand.AddOption(TimeoutOption);

        return rootCommand;
    }

    /// <summary>
    /// Parses command-line arguments into a CliOptions instance.
    /// </summary>
    public static CliOptions FromParseResult(System.CommandLine.Parsing.ParseResult result)
    {
        return new CliOptions
        {
            Mode = result.GetValueForArgument(ModeArg),
            Client = result.GetValueForOption(ClientOption),
            Server = result.GetValueForOption(ServerOption),
            Skeleton = result.GetValueForOption(SkeletonOption),
            Config = result.GetValueForOption(ConfigOption),
            Store = result.GetValueForOption(StoreOption),
            DryRun = result.GetValueForOption(DryRunOption),
            TruncateSeq = result.GetValueForOption(TruncateSeqOption),
            Log = result.GetValueForOption(LogOption),
            Timeout = result.GetValueForOption(TimeoutOption),
        };
    }

    // ─────────────────────────────────────────────────────────────────────────
    // Option Definitions
    // ─────────────────────────────────────────────────────────────────────────

    private static readonly Argument<string> ModeArg = new(
        name: "mode",
        getDefaultValue: () => "reset",
        description: "Operating mode: reset, recovery, broker-reset, clear");

    private static readonly Option<bool> ClientOption = new(
        aliases: ["--client", "-c"],
        description: "Run client (initiator) only");

    private static readonly Option<bool> ServerOption = new(
        aliases: ["--server", "-S"],
        description: "Run server (acceptor) only");

    private static readonly Option<bool> SkeletonOption = new(
        name: "--skeleton",
        description: "Skeleton mode - no app messages, only heartbeats (for GC baseline testing)");

    private static readonly Option<string?> ConfigOption = new(
        name: "--config",
        description: "Custom config file path (for --client or --server)");

    private static readonly Option<string?> StoreOption = new(
        aliases: ["--store", "-s"],
        description: "Use file store in specified directory");

    private static readonly Option<bool> DryRunOption = new(
        name: "--dry-run",
        description: "Read and display file store state, then exit without starting session");

    private static readonly Option<int?> TruncateSeqOption = new(
        name: "--truncate-seq",
        description: "Truncate sender sequence number to specified value (use with --client and --store)");

    private static readonly Option<bool> LogOption = new(
        aliases: ["--log", "-l"],
        description: "Enable file logging to logs/ directory");

    private static readonly Option<int?> TimeoutOption = new(
        aliases: ["--timeout", "-t"],
        description: "Exit after specified number of seconds");
}

/// <summary>
/// Binder for CliOptions - allows using SetHandler with the options type directly.
/// </summary>
public class CliOptionsBinder : BinderBase<CliOptions>
{
    protected override CliOptions GetBoundValue(BindingContext bindingContext)
    {
        return CliOptions.FromParseResult(bindingContext.ParseResult);
    }
}

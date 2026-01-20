using PureFix.Buffer;
using PureFix.Buffer.Ascii;
using PureFix.Transport;
using PureFix.Transport.Recovery;
using PureFix.Transport.Session;
using PureFix.Types;
using PureFix.Types.Config;

namespace TradeCaptureDemo.Support;

/// <summary>
/// Session factory that creates a fresh parser per session.
/// This ensures thread isolation - each session has its own parse state.
/// Critical for acceptors with multiple concurrent clients.
/// </summary>
public class DemoSessionFactory(
    IFixConfig config,
    IFixLogRecovery? fixLogRecovery,
    ILogFactory logFactory,
    IFixMessageFactory fixMessageFactory,
    IMessageEncoder encoder,
    IFixClock clock)
    : ISessionFactory
{
    /// <summary>
    /// Stores the original TargetCompID at factory construction time.
    /// This is needed because the config's description may be modified by sessions.
    /// </summary>
    private readonly string? _originalTargetCompId = config.Description?.TargetCompID;

    /// <summary>
    /// Tracks if the original config uses wildcard TargetCompID.
    /// When true, each session gets its own cloned description to avoid sharing state.
    /// </summary>
    private readonly bool _isWildcardMode = config.Description?.TargetCompID == "*" && !config.IsInitiator();

    public FixSession MakeSession()
    {
        // Create a NEW parser per session to ensure thread isolation.
        // The parser holds mutable state (_state, _pool) that is not thread-safe.
        // If multiple sessions shared one parser, concurrent ParseFrom() calls
        // would corrupt each other's state.
        var parser = new AsciiParser(config.Definitions!)
        {
            Delimiter = config.Delimiter
        };

        // For wildcard mode acceptors, create a per-session config with cloned description.
        // This prevents sessions from sharing the TargetCompID field which gets updated
        // from each client's SenderCompID during Logon.
        if (_isWildcardMode)
        {
            var (sessionConfig, sessionEncoder) = CreatePerSessionConfigAndEncoder();
            return new DemoServer(sessionConfig, fixLogRecovery, logFactory, fixMessageFactory, parser, sessionEncoder, clock);
        }

        FixSession entity = config.IsInitiator()
            ? new DemoClient(config, fixLogRecovery, logFactory, fixMessageFactory, parser, encoder, clock)
            : new DemoServer(config, fixLogRecovery, logFactory, fixMessageFactory, parser, encoder, clock);

        return entity;
    }

    /// <summary>
    /// Creates a per-session config and encoder with a cloned description for wildcard mode.
    /// Each session gets its own TargetCompID that can be updated from the client's SenderCompID.
    /// The encoder must also be per-session because it uses the message factory to build headers.
    /// </summary>
    private (IFixConfig, IMessageEncoder) CreatePerSessionConfigAndEncoder()
    {
        if (config.Description is not SessionDescription originalDesc)
            return (config, encoder);

        var clonedDesc = originalDesc.Clone();

        // Ensure the clone has the original wildcard TargetCompID, not a value that may have
        // been modified by a previous session. This is critical for multi-client support.
        if (_originalTargetCompId == "*")
        {
            clonedDesc.TargetCompID = "*";
        }

        // Create a new message factory with the cloned description so headers use per-session TargetCompID
        var perSessionMessageFactory = new Fix50SP2SessionMessageFactory(clonedDesc);

        var perSessionConfig = new FixConfig
        {
            Definitions = config.Definitions,
            Description = clonedDesc,
            MessageFactory = perSessionMessageFactory,
            SessionStoreFactory = config.SessionStoreFactory,
            SessionRegistry = config.SessionRegistry
        };

        // Create a new encoder with the cloned description and per-session message factory
        // This is critical - the encoder uses the message factory to build headers!
        var perSessionEncoder = new AsciiEncoder(
            config.Definitions!,
            clonedDesc,
            perSessionMessageFactory,
            clock);

        return (perSessionConfig, perSessionEncoder);
    }
}

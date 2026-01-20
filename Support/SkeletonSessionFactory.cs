using PureFix.Buffer;
using PureFix.Buffer.Ascii;
using PureFix.Transport;
using PureFix.Transport.Recovery;
using PureFix.Transport.Session;
using PureFix.Types;
using PureFix.Types.Config;

namespace TradeCaptureDemo.Support;

/// <summary>
/// Session factory for skeleton mode.
/// Creates SkeletonHandler for both initiator and acceptor roles.
/// Creates a fresh parser per session to ensure thread isolation.
/// Supports wildcard TargetCompID for multi-client acceptors.
/// </summary>
public class SkeletonSessionFactory(
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
    /// </summary>
    private readonly string? _originalTargetCompId = config.Description?.TargetCompID;

    /// <summary>
    /// Tracks if the original config uses wildcard TargetCompID.
    /// </summary>
    private readonly bool _isWildcardMode = config.Description?.TargetCompID == "*" && !config.IsInitiator();

    public FixSession MakeSession()
    {
        // Create a NEW parser per session to ensure thread isolation.
        var parser = new AsciiParser(config.Definitions!)
        {
            Delimiter = config.Delimiter
        };

        // For wildcard mode acceptors, create a per-session config with cloned description.
        if (_isWildcardMode)
        {
            var (sessionConfig, sessionEncoder) = CreatePerSessionConfigAndEncoder();
            return new SkeletonHandler(sessionConfig, fixLogRecovery, logFactory, fixMessageFactory, parser, sessionEncoder, clock);
        }

        return new SkeletonHandler(config, fixLogRecovery, logFactory, fixMessageFactory, parser, encoder, clock);
    }

    /// <summary>
    /// Creates a per-session config and encoder with a cloned description for wildcard mode.
    /// </summary>
    private (IFixConfig, IMessageEncoder) CreatePerSessionConfigAndEncoder()
    {
        if (config.Description is not SessionDescription originalDesc)
            return (config, encoder);

        var clonedDesc = originalDesc.Clone();

        // Ensure the clone has the original wildcard TargetCompID
        if (_originalTargetCompId == "*")
        {
            clonedDesc.TargetCompID = "*";
        }

        var perSessionMessageFactory = new Fix50SP2SessionMessageFactory(clonedDesc);

        var perSessionConfig = new FixConfig
        {
            Definitions = config.Definitions,
            Description = clonedDesc,
            MessageFactory = perSessionMessageFactory,
            SessionStoreFactory = config.SessionStoreFactory,
            SessionRegistry = config.SessionRegistry
        };

        var perSessionEncoder = new AsciiEncoder(
            config.Definitions!,
            clonedDesc,
            perSessionMessageFactory,
            clock);

        return (perSessionConfig, perSessionEncoder);
    }
}

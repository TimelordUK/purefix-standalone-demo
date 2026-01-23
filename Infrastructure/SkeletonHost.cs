using PureFix.Transport.Session;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC;

namespace TradeCaptureDemo.Infrastructure;

/// <summary>
/// DI host for skeleton mode.
/// Uses SkeletonSessionFactory to create minimal handlers for GC baseline testing.
/// </summary>
internal class SkeletonHost(ILogFactory factory, IFixClock clock, IFixConfig config)
    : AppHost<SkeletonSessionFactory, FixMessageFactory, Fix50SP2SessionMessageFactory>(factory, clock, config);

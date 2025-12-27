using Arrow.Threading.Tasks;
using PureFix.Transport.Session;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC;

namespace TradeCaptureDemo.Support;

/// <summary>
/// DI host for skeleton mode.
/// Uses SkeletonSessionFactory to create minimal handlers for GC baseline testing.
/// </summary>
internal class SkeletonHost(AsyncWorkQueue q, ILogFactory factory, IFixClock clock, IFixConfig config)
    : AppHost<SkeletonSessionFactory, FixMessageFactory, Fix50SP2SessionMessageFactory>(q, factory, clock, config);

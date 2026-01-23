using Arrow.Threading.Tasks;
using PureFix.Transport.Session;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC;

namespace TradeCaptureDemo.Infrastructure;

internal class TradeCaptureHost(ILogFactory factory, IFixClock clock, IFixConfig config)
    : AppHost<TradeCaptureSessionFactory, FixMessageFactory, Fix50SP2SessionMessageFactory>(factory, clock, config);

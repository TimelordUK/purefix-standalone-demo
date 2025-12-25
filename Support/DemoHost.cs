using Arrow.Threading.Tasks;
using PureFix.Transport.Session;
using PureFix.Types;
using PureFix.Types.FIX50SP2;

namespace TradeCaptureDemo.Support;

internal class DemoHost : AppHost<DemoSessionFactory, FixMessageFactory, Fix50SP2SessionMessageFactory>
{
    public DemoHost(AsyncWorkQueue q, ILogFactory factory, IFixClock clock, IFixConfig config)
        : base(q, factory, clock, config)
    {
    }
}

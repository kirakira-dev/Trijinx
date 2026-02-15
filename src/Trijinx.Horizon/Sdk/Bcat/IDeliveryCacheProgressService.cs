using Trijinx.Horizon.Bcat.Ipc.Types;
using Trijinx.Horizon.Common;
using Trijinx.Horizon.Sdk.Sf;

namespace Trijinx.Horizon.Sdk.Bcat
{
    internal interface IDeliveryCacheProgressService : IServiceObject
    {
        Result GetEvent(out int handle);
        Result GetImpl(out DeliveryCacheProgressImpl deliveryCacheProgressImpl);
    }
}

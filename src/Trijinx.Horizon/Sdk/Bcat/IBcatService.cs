using Trijinx.Horizon.Common;
using Trijinx.Horizon.Sdk.Sf;

namespace Trijinx.Horizon.Sdk.Bcat
{
    internal interface IBcatService : IServiceObject
    {
        Result RequestSyncDeliveryCache(out IDeliveryCacheProgressService deliveryCacheProgressService);
    }
}

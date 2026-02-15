using Trijinx.Horizon.Bcat.Types;
using Trijinx.Horizon.Common;
using Trijinx.Horizon.Sdk.Bcat;
using Trijinx.Horizon.Sdk.Sf;

namespace Trijinx.Horizon.Bcat.Ipc
{
    partial class BcatService : IBcatService
    {
        public BcatService(BcatServicePermissionLevel permissionLevel) { }

        [CmifCommand(10100)]
        public Result RequestSyncDeliveryCache(out IDeliveryCacheProgressService deliveryCacheProgressService)
        {
            deliveryCacheProgressService = new DeliveryCacheProgressService();

            return Result.Success;
        }
    }
}

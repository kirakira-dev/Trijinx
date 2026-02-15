using Trijinx.Horizon.Common;
using Trijinx.Horizon.Sdk.Ncm;
using Trijinx.Horizon.Sdk.Sf;

namespace Trijinx.Horizon.Sdk.Bcat
{
    internal interface IServiceCreator : IServiceObject
    {
        Result CreateBcatService(out IBcatService service, ulong pid);
        Result CreateDeliveryCacheStorageService(out IDeliveryCacheStorageService service, ulong pid);
        Result CreateDeliveryCacheStorageServiceWithApplicationId(out IDeliveryCacheStorageService service, ApplicationId applicationId);
    }
}

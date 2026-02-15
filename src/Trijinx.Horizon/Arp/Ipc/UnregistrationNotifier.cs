using Trijinx.Horizon.Common;
using Trijinx.Horizon.Sdk.Arp;
using Trijinx.Horizon.Sdk.Arp.Detail;
using Trijinx.Horizon.Sdk.Sf;

namespace Trijinx.Horizon.Arp.Ipc
{
    partial class UnregistrationNotifier : IUnregistrationNotifier, IServiceObject
    {
        private readonly ApplicationInstanceManager _applicationInstanceManager;

        public UnregistrationNotifier(ApplicationInstanceManager applicationInstanceManager)
        {
            _applicationInstanceManager = applicationInstanceManager;
        }

        [CmifCommand(0)]
        public Result GetReadableHandle([CopyHandle] out int readableHandle)
        {
            readableHandle = _applicationInstanceManager.EventHandle;

            return Result.Success;
        }
    }
}

using Trijinx.Horizon.Common;
using Trijinx.Horizon.Sdk.Sf;

namespace Trijinx.Horizon.Sdk.Friends.Detail.Ipc
{
    interface INotificationService : IServiceObject
    {
        Result GetEvent(out int eventHandle);
        Result Clear();
        Result Pop(out SizedNotificationInfo sizedNotificationInfo);
    }
}

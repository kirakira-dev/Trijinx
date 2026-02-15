using Trijinx.Horizon.Common;
using Trijinx.Horizon.Sdk.Account;
using Trijinx.Horizon.Sdk.Sf;

namespace Trijinx.Horizon.Sdk.Friends.Detail.Ipc
{
    interface IServiceCreator : IServiceObject
    {
        Result CreateFriendService(out IFriendService friendService);
        Result CreateNotificationService(out INotificationService notificationService, Uid userId);
        Result CreateDaemonSuspendSessionService(out IDaemonSuspendSessionService daemonSuspendSessionService);
    }
}

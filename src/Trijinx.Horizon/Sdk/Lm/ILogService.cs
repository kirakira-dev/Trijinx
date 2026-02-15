using Trijinx.Horizon.Common;
using Trijinx.Horizon.LogManager.Ipc;
using Trijinx.Horizon.Sdk.Sf;

namespace Trijinx.Horizon.Sdk.Lm
{
    interface ILogService : IServiceObject
    {
        Result OpenLogger(out LmLogger logger, ulong pid);
    }
}

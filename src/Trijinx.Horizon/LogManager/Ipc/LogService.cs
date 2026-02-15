using Trijinx.Horizon.Common;
using Trijinx.Horizon.Sdk.Lm;
using Trijinx.Horizon.Sdk.Sf;

namespace Trijinx.Horizon.LogManager.Ipc
{
    partial class LogService : ILogService
    {
        public LogDestination LogDestination { get; set; } = LogDestination.TargetManager;

        [CmifCommand(0)]
        public Result OpenLogger(out LmLogger logger, [ClientProcessId] ulong pid)
        {
            // NOTE: Internal name is Logger, but we rename it to LmLogger to avoid name clash with Trijinx.Common.Logging logger.
            logger = new LmLogger(this, pid);

            return Result.Success;
        }
    }
}

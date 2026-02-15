using MsgPack;
using Trijinx.Horizon.Sdk.Account;
using Trijinx.Horizon.Sdk.Ncm;

namespace Trijinx.Horizon.Prepo.Types
{
    public struct PlayReport
    {
        public PlayReportKind Kind { get; init; }
        public string Room { get; init; }
        public MessagePackObject ReportData { get; init; }

        public ApplicationId? AppId;
        public ulong? Pid;
        public uint Version;
        public Uid? UserId;
    }

    public enum PlayReportKind
    {
        Normal,
        System,
    }
}

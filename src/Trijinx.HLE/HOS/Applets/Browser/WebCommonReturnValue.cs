using Trijinx.Common.Memory;

namespace Trijinx.HLE.HOS.Applets.Browser
{
    public struct WebCommonReturnValue
    {
        public WebExitReason ExitReason;
        public uint Padding;
        public ByteArray4096 LastUrl;
        public ulong LastUrlSize;
    }
}

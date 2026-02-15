using System.Runtime.InteropServices;

namespace Trijinx.HLE.HOS.Services.Ldn.UserServiceCreator.LdnRyu.Types
{
    [StructLayout(LayoutKind.Sequential, Size = 0x2)]
    struct PingMessage
    {
        public byte Requester;
        public byte Id;
    }
}

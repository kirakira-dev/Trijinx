using Trijinx.Common.Memory;
using System.Runtime.InteropServices;

namespace Trijinx.HLE.HOS.Services.Ldn.Types
{
    [StructLayout(LayoutKind.Sequential, Size = 0x20, Pack = 1)]
    struct SecurityParameter
    {
        public Array16<byte> Data;
        public Array16<byte> SessionId;
    }
}

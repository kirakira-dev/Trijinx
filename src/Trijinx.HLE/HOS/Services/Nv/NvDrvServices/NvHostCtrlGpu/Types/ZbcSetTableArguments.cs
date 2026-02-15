using Trijinx.Common.Memory;
using System.Runtime.InteropServices;

namespace Trijinx.HLE.HOS.Services.Nv.NvDrvServices.NvHostCtrlGpu.Types
{
    [StructLayout(LayoutKind.Sequential)]
    struct ZbcSetTableArguments
    {
        public Array4<uint> ColorDs;
        public Array4<uint> ColorL2;
        public uint Depth;
        public uint Format;
        public uint Type;
    }
}

using System.Runtime.InteropServices;

namespace Trijinx.HLE.HOS.Services.Nv.NvDrvServices.NvHostCtrlGpu.Types
{
    [StructLayout(LayoutKind.Sequential)]
    struct ZcullGetCtxSizeArguments
    {
        public int Size;
    }
}

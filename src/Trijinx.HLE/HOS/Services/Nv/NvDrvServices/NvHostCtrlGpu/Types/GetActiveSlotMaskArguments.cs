using System.Runtime.InteropServices;

namespace Trijinx.HLE.HOS.Services.Nv.NvDrvServices.NvHostCtrlGpu.Types
{
    [StructLayout(LayoutKind.Sequential)]
    struct GetActiveSlotMaskArguments
    {
        public int Slot;
        public int Mask;
    }
}

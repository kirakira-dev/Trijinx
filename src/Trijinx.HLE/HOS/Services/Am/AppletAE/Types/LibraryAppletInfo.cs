using System.Runtime.InteropServices;

namespace Trijinx.HLE.HOS.Services.Am.AppletAE
{
    [StructLayout(LayoutKind.Sequential, Size = 0x8)]
    struct LibraryAppletInfo
    {
        public AppletId AppletId;
        public LibraryAppletMode LibraryAppletMode;
    }
}

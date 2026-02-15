using Trijinx.Graphics.Device;
using Trijinx.Graphics.Nvdec.Image;

namespace Trijinx.Graphics.Nvdec
{
    readonly struct ResourceManager
    {
        public DeviceMemoryManager MemoryManager { get; }
        public SurfaceCache Cache { get; }

        public ResourceManager(DeviceMemoryManager mm, SurfaceCache cache)
        {
            MemoryManager = mm;
            Cache = cache;
        }
    }
}

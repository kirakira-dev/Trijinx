using Trijinx.Common.Memory;

namespace Trijinx.Graphics.Nvdec.Vp9
{
    internal struct TileBuffer
    {
        public int Col;
        public ArrayPtr<byte> Data;
        public int Size;
    }
}

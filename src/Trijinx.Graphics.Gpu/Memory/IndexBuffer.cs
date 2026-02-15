using Trijinx.Graphics.GAL;
using Trijinx.Memory.Range;

namespace Trijinx.Graphics.Gpu.Memory
{
    /// <summary>
    /// GPU Index Buffer information.
    /// </summary>
    struct IndexBuffer
    {
        public MultiRange Range;
        public IndexType Type;
    }
}

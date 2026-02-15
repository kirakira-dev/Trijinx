using Trijinx.Graphics.Shader.Decoders;
using Trijinx.Graphics.Shader.Translation;

namespace Trijinx.Graphics.Shader.Instructions
{
    static partial class InstEmit
    {
        public static void Nop(EmitterContext context)
        {
            context.GetOp<InstNop>();

            // No operation.
        }
    }
}

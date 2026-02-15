using Trijinx.Graphics.GAL;

namespace Trijinx.Graphics.OpenGL.Image
{
    interface ITextureInfo
    {
        ITextureInfo Storage { get; }
        int Handle { get; }
        int FirstLayer => 0;
        int FirstLevel => 0;

        TextureCreateInfo Info { get; }
    }
}

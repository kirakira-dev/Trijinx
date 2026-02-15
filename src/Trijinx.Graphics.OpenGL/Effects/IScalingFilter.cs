using Trijinx.Graphics.GAL;
using Trijinx.Graphics.OpenGL.Image;
using System;

namespace Trijinx.Graphics.OpenGL.Effects
{
    internal interface IScalingFilter : IDisposable
    {
        float Level { get; set; }
        void Run(
            TextureView view,
            TextureView destinationTexture,
            int width,
            int height,
            Extents2D source,
            Extents2D destination);
    }
}

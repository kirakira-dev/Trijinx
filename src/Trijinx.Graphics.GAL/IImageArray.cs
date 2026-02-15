using System;

namespace Trijinx.Graphics.GAL
{
    public interface IImageArray : IDisposable
    {
        void SetImages(int index, ITexture[] images);
    }
}

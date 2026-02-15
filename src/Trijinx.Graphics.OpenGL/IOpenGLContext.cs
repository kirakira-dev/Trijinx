using System;

namespace Trijinx.Graphics.OpenGL
{
    public interface IOpenGLContext : IDisposable
    {
        void MakeCurrent();

        bool HasContext();
    }
}

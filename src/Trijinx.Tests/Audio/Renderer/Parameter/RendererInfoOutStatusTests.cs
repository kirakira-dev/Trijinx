using NUnit.Framework;
using Trijinx.Audio.Renderer.Parameter;
using System.Runtime.CompilerServices;

namespace Trijinx.Tests.Audio.Renderer.Parameter
{
    class RendererInfoOutStatusTests
    {
        [Test]
        public void EnsureTypeSize()
        {
            Assert.AreEqual(0x10, Unsafe.SizeOf<RendererInfoOutStatus>());
        }
    }
}

using NUnit.Framework;
using Trijinx.Audio.Renderer.Parameter;
using System.Runtime.CompilerServices;

namespace Trijinx.Tests.Audio.Renderer
{
    class AudioRendererConfigurationTests
    {
        [Test]
        public void EnsureTypeSize()
        {
            Assert.AreEqual(0x34, Unsafe.SizeOf<AudioRendererConfiguration>());
        }
    }
}

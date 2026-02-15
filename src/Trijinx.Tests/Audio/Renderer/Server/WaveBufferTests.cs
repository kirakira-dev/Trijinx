using NUnit.Framework;
using Trijinx.Audio.Renderer.Server.Voice;
using System.Runtime.CompilerServices;

namespace Trijinx.Tests.Audio.Renderer.Server
{
    class WaveBufferTests
    {
        [Test]
        public void EnsureTypeSize()
        {
            Assert.AreEqual(0x58, Unsafe.SizeOf<WaveBuffer>());
        }
    }
}

using NUnit.Framework;
using Trijinx.Audio.Renderer.Common;
using System.Runtime.CompilerServices;

namespace Trijinx.Tests.Audio.Renderer.Common
{
    class WaveBufferTests
    {
        [Test]
        public void EnsureTypeSize()
        {
            Assert.AreEqual(0x30, Unsafe.SizeOf<WaveBuffer>());
        }
    }
}

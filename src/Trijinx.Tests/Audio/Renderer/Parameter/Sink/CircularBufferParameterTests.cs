using NUnit.Framework;
using Trijinx.Audio.Renderer.Parameter.Sink;
using System.Runtime.CompilerServices;

namespace Trijinx.Tests.Audio.Renderer.Parameter.Sink
{
    class CircularBufferParameterTests
    {
        [Test]
        public void EnsureTypeSize()
        {
            Assert.AreEqual(0x24, Unsafe.SizeOf<CircularBufferParameter>());
        }
    }
}

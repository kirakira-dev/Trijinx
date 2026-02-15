using NUnit.Framework;
using Trijinx.Audio.Renderer.Parameter.Effect;
using System.Runtime.CompilerServices;

namespace Trijinx.Tests.Audio.Renderer.Parameter.Effect
{
    class BufferMixerParameterTests
    {
        [Test]
        public void EnsureTypeSize()
        {
            Assert.AreEqual(0x94, Unsafe.SizeOf<BufferMixParameter>());
        }
    }
}

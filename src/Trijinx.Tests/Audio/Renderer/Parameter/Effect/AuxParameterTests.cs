using NUnit.Framework;
using Trijinx.Audio.Renderer.Parameter.Effect;
using System.Runtime.CompilerServices;

namespace Trijinx.Tests.Audio.Renderer.Parameter.Effect
{
    class AuxParameterTests
    {
        [Test]
        public void EnsureTypeSize()
        {
            Assert.AreEqual(0x6C, Unsafe.SizeOf<AuxiliaryBufferParameter>());
        }
    }
}

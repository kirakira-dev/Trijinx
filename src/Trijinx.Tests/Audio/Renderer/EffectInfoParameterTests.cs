using NUnit.Framework;
using Trijinx.Audio.Renderer.Parameter;
using System.Runtime.CompilerServices;

namespace Trijinx.Tests.Audio.Renderer
{
    class EffectInfoParameterTests
    {
        [Test]
        public void EnsureTypeSize()
        {
            Assert.AreEqual(0xC0, Unsafe.SizeOf<EffectInParameterVersion1>());
            Assert.AreEqual(0xC0, Unsafe.SizeOf<EffectInParameterVersion2>());
        }
    }
}

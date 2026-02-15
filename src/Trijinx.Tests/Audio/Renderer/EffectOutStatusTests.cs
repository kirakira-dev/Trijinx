using NUnit.Framework;
using Trijinx.Audio.Renderer.Parameter;
using System.Runtime.CompilerServices;

namespace Trijinx.Tests.Audio.Renderer
{
    class EffectOutStatusTests
    {
        [Test]
        public void EnsureTypeSize()
        {
            Assert.AreEqual(0x10, Unsafe.SizeOf<EffectOutStatusVersion1>());
            Assert.AreEqual(0x90, Unsafe.SizeOf<EffectOutStatusVersion2>());
        }
    }
}

using NUnit.Framework;
using Trijinx.Audio.Renderer.Server.Mix;
using System.Runtime.CompilerServices;

namespace Trijinx.Tests.Audio.Renderer.Server
{
    class MixInfoTests
    {
        [Test]
        public void EnsureTypeSize()
        {
            Assert.AreEqual(0x940, Unsafe.SizeOf<MixInfo>());
        }
    }
}

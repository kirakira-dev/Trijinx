using NUnit.Framework;
using Trijinx.Audio.Renderer.Server.Voice;
using System.Runtime.CompilerServices;

namespace Trijinx.Tests.Audio.Renderer.Server
{
    class VoiceInfoTests
    {
        [Test]
        public void EnsureTypeSize()
        {
            Assert.LessOrEqual(Unsafe.SizeOf<VoiceInfo>(), 0x238);
        }
    }
}

using NUnit.Framework;
using Trijinx.Audio.Renderer.Common;
using System.Runtime.CompilerServices;

namespace Trijinx.Tests.Audio.Renderer.Common
{
    class VoiceStateTests
    {
        [Test]
        public void EnsureTypeSize()
        {
            Assert.LessOrEqual(Unsafe.SizeOf<VoiceState>(), 0x100);
        }
    }
}

using NUnit.Framework;
using Trijinx.Audio.Renderer.Parameter;
using System.Runtime.CompilerServices;

namespace Trijinx.Tests.Audio.Renderer
{
    class VoiceChannelResourceInParameterTests
    {
        [Test]
        public void EnsureTypeSize()
        {
            Assert.AreEqual(0x70, Unsafe.SizeOf<VoiceChannelResourceInParameter>());
        }
    }
}

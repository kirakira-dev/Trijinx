using NUnit.Framework;
using Trijinx.Audio.Renderer.Parameter.Sink;
using System.Runtime.CompilerServices;

namespace Trijinx.Tests.Audio.Renderer.Parameter.Sink
{
    class DeviceParameterTests
    {
        [Test]
        public void EnsureTypeSize()
        {
            Assert.AreEqual(0x11C, Unsafe.SizeOf<DeviceParameter>());
        }
    }
}

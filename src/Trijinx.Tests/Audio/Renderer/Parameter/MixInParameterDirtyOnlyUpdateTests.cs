using NUnit.Framework;
using Trijinx.Audio.Renderer.Parameter;
using System.Runtime.CompilerServices;

namespace Trijinx.Tests.Audio.Renderer.Parameter
{
    class MixInParameterDirtyOnlyUpdateTests
    {
        [Test]
        public void EnsureTypeSize()
        {
            Assert.AreEqual(0x20, Unsafe.SizeOf<MixInParameterDirtyOnlyUpdate>());
        }
    }
}

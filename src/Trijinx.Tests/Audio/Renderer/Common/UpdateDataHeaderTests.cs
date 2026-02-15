using NUnit.Framework;
using Trijinx.Audio.Renderer.Common;
using System.Runtime.CompilerServices;

namespace Trijinx.Tests.Audio.Renderer.Common
{
    class UpdateDataHeaderTests
    {
        [Test]
        public void EnsureTypeSize()
        {
            Assert.AreEqual(0x40, Unsafe.SizeOf<UpdateDataHeader>());
        }
    }
}

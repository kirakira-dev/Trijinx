using NUnit.Framework;
using Trijinx.Audio.Renderer.Parameter.Effect;
using System.Runtime.CompilerServices;

namespace Trijinx.Tests.Audio.Renderer.Parameter.Effect
{
    class LimiterStatisticsTests
    {
        [Test]
        public void EnsureTypeSize()
        {
            Assert.AreEqual(0x30, Unsafe.SizeOf<LimiterStatistics>());
        }
    }
}

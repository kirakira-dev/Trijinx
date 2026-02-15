using NUnit.Framework;
using Trijinx.HLE.HOS.Services.Time.TimeZone;
using System.Runtime.CompilerServices;

namespace Trijinx.Tests.Time
{
    internal class TimeZoneRuleTests
    {
        class EffectInfoParameterTests
        {
            [Test]
            public void EnsureTypeSize()
            {
                Assert.AreEqual(0x4000, Unsafe.SizeOf<TimeZoneRule>());
            }
        }
    }
}

using System.Diagnostics;

namespace Trijinx.Horizon.Sdk
{
    static class DebugUtil
    {
        public static void Assert(bool condition)
        {
            Debug.Assert(condition);
        }
    }
}

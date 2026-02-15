using System;

namespace Trijinx.HLE.HOS.Kernel.SupervisorCall
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
    class SvcImplAttribute : Attribute
    {
    }
}

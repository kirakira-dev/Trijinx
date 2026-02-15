using System;

namespace Trijinx.HLE.HOS.Kernel.SupervisorCall
{
    [AttributeUsage(AttributeTargets.Parameter, AllowMultiple = false, Inherited = true)]
    class PointerSizedAttribute : Attribute
    {
    }
}

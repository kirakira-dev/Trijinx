using System;

namespace Trijinx.HLE.Exceptions
{
    public class TamperCompilationException : Exception
    {
        public TamperCompilationException(string message) : base(message) { }
    }
}

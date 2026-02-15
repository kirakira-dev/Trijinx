using System;

namespace Trijinx.HLE.Exceptions
{
    public class InvalidSystemResourceException : Exception
    {
        public InvalidSystemResourceException(string message) : base(message) { }
    }
}

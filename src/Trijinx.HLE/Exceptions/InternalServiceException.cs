using System;

namespace Trijinx.HLE.Exceptions
{
    class InternalServiceException : Exception
    {
        public InternalServiceException(string message) : base(message) { }
    }
}

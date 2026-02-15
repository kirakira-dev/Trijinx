using System;

namespace Trijinx.HLE.Exceptions
{
    class InvalidFirmwarePackageException : Exception
    {
        public InvalidFirmwarePackageException(string message) : base(message) { }
    }
}

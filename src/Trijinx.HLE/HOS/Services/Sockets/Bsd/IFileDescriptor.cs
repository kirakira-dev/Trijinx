using Trijinx.HLE.HOS.Services.Sockets.Bsd.Types;
using System;

namespace Trijinx.HLE.HOS.Services.Sockets.Bsd
{
    interface IFileDescriptor : IDisposable
    {
        bool Blocking { get; set; }
        int Refcount { get; set; }

        LinuxError Read(out int readSize, Span<byte> buffer);

        LinuxError Write(out int writeSize, ReadOnlySpan<byte> buffer);
    }
}

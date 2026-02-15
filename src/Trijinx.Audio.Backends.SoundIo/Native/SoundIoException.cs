using System;
using System.Runtime.InteropServices;
using static Trijinx.Audio.Backends.SoundIo.Native.SoundIo;

namespace Trijinx.Audio.Backends.SoundIo.Native
{
    internal class SoundIoException : Exception
    {
        internal SoundIoException(SoundIoError error) : base(Marshal.PtrToStringAnsi(soundio_strerror(error))) { }
    }
}

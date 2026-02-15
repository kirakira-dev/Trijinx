using System;

namespace Trijinx.Graphics.GAL
{
    public interface IProgram : IDisposable
    {
        ProgramLinkStatus CheckProgramLink(bool blocking);

        byte[] GetBinary();
    }
}

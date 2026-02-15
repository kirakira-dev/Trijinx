using Trijinx.Common.Memory;
using System.Runtime.InteropServices;

namespace Trijinx.HLE.HOS.Services.Ldn.UserServiceCreator.LdnRyu.Types
{
    [StructLayout(LayoutKind.Sequential, Size = 0x80)]
    struct PassphraseMessage
    {
        public Array128<byte> Passphrase;
    }
}

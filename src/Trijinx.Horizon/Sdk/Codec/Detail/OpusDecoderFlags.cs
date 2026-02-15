using System;

namespace Trijinx.Horizon.Sdk.Codec.Detail
{
    [Flags]
    enum OpusDecoderFlags : uint
    {
        None,
        LargeFrameSize = 1 << 0,
    }
}

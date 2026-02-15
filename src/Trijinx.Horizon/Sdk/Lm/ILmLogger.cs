using Trijinx.Horizon.Common;
using Trijinx.Horizon.Sdk.Sf;
using System;

namespace Trijinx.Horizon.Sdk.Lm
{
    interface ILmLogger : IServiceObject
    {
        Result Log(Span<byte> message);
        Result SetDestination(LogDestination destination);
    }
}

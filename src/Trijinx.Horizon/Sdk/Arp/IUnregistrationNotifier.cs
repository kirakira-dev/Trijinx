using Trijinx.Horizon.Common;

namespace Trijinx.Horizon.Sdk.Arp
{
    public interface IUnregistrationNotifier
    {
        public Result GetReadableHandle(out int readableHandle);
    }
}

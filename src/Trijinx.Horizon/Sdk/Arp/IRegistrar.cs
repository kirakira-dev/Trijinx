using Trijinx.Horizon.Common;
using Trijinx.Horizon.Sdk.Ns;

namespace Trijinx.Horizon.Sdk.Arp
{
    public interface IRegistrar
    {
        public Result Issue(out ulong applicationInstanceId);
        public Result SetApplicationLaunchProperty(ApplicationLaunchProperty applicationLaunchProperty);
        public Result SetApplicationControlProperty(in ApplicationControlProperty applicationControlProperty);
    }
}

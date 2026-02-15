using Trijinx.Horizon.Common;
using Trijinx.Horizon.Sdk.Sf;

namespace Trijinx.Horizon.Sdk.Ts
{
    interface ISession : IServiceObject
    {
        Result GetTemperatureRange(out int minimumTemperature, out int maximumTemperature);
        Result GetTemperature(out int temperature);
        Result SetMeasurementMode(byte measurementMode);
    }
}

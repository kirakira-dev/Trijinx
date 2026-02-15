using System.Text.Json.Serialization;

namespace Trijinx.Common.Configuration
{
    [JsonConverter(typeof(JsonStringEnumConverter<ScalingFilter>))]
    public enum ScalingFilter
    {
        Bilinear,
        Nearest,
        Fsr,
        Area,
    }
}

using System.Text.Json.Serialization;

namespace Trijinx.Common.Configuration
{
    [JsonConverter(typeof(JsonStringEnumConverter<AntiAliasing>))]
    public enum AntiAliasing
    {
        None,
        Fxaa,
        SmaaLow,
        SmaaMedium,
        SmaaHigh,
        SmaaUltra,
    }
}

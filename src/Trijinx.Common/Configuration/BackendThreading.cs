using System.Text.Json.Serialization;

namespace Trijinx.Common.Configuration
{
    [JsonConverter(typeof(JsonStringEnumConverter<BackendThreading>))]
    public enum BackendThreading
    {
        Auto,
        Off,
        On,
    }
}

using System.Text.Json.Serialization;

namespace Trijinx.Common.Configuration
{
    [JsonConverter(typeof(JsonStringEnumConverter<GraphicsDebugLevel>))]
    public enum GraphicsDebugLevel
    {
        None,
        Error,
        Slowdowns,
        All,
    }
}

using System.Text.Json.Serialization;

namespace Trijinx.Common.Configuration
{
    [JsonConverter(typeof(JsonStringEnumConverter<GraphicsBackend>))]
    public enum GraphicsBackend
    {
        Vulkan,
        OpenGl,
    }
}

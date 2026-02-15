using System.Text.Json.Serialization;

namespace Trijinx.Ava.Systems.Configuration
{
    [JsonConverter(typeof(JsonStringEnumConverter<AudioBackend>))]
    public enum AudioBackend
    {
        Dummy,
        OpenAl,
        SoundIo,
        SDL3,
        SDL2 = SDL3
    }
}

using System.Text.Json.Serialization;

namespace Trijinx.Common.Configuration.Hid
{
    [JsonConverter(typeof(JsonStringEnumConverter<InputBackendType>))]
    public enum InputBackendType
    {
        Invalid,
        WindowKeyboard,
        GamepadSDL2, //backcompat
        GamepadSDL3,
    }
}

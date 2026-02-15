using System.Text.Json.Serialization;

namespace Trijinx.Common.Configuration.Hid.Controller.Motion
{
    [JsonConverter(typeof(JsonStringEnumConverter<MotionInputBackendType>))]
    public enum MotionInputBackendType : byte
    {
        Invalid,
        GamepadDriver,
        CemuHook,
    }
}

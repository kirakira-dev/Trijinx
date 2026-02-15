using System.Text.Json.Serialization;

namespace Trijinx.Common.Configuration.Hid.Controller
{
    [JsonConverter(typeof(JsonStringEnumConverter<StickInputId>))]
    public enum StickInputId : byte
    {
        Unbound,
        Left,
        Right,
        
        Count,
    }
}

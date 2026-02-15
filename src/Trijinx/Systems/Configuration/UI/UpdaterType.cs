using System.Text.Json.Serialization;

namespace Trijinx.Ava.Systems.Configuration.UI
{
    [JsonConverter(typeof(JsonStringEnumConverter<UpdaterType>))]
    public enum UpdaterType
    {
        Off,
        PromptAtStartup,
        CheckInBackground
    }
}

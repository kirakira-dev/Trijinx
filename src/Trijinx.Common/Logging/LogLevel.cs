using System.Text.Json.Serialization;

namespace Trijinx.Common.Logging
{
    [JsonConverter(typeof(JsonStringEnumConverter<LogLevel>))]
    public enum LogLevel
    {
        Debug,
        Stub,
        Info,
        Warning,
        Error,
        Guest,
        AccessLog,
        Notice,
        Trace,
    }
}

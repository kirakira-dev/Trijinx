using System.Text.Json.Serialization;

namespace Trijinx.Ava.Systems.Configuration
{
    [JsonSourceGenerationOptions(WriteIndented = true)]
    [JsonSerializable(typeof(ConfigurationFileFormat))]
    internal partial class ConfigurationJsonSerializerContext : JsonSerializerContext;
}

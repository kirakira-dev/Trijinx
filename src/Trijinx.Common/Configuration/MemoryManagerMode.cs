using System.Text.Json.Serialization;

namespace Trijinx.Common.Configuration
{
    [JsonConverter(typeof(JsonStringEnumConverter<MemoryManagerMode>))]
    public enum MemoryManagerMode : byte
    {
        SoftwarePageTable,
        HostMapped,
        HostMappedUnsafe,
    }
}

using System.Text.Json.Serialization;

namespace Trijinx.Ava.Common.Models.Amiibo
{
    [JsonSerializable(typeof(AmiiboJson))]
    public partial class AmiiboJsonSerializerContext : JsonSerializerContext;
}

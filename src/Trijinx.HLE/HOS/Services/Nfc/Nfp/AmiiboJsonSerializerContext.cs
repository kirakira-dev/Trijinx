using Trijinx.HLE.HOS.Services.Nfc.Nfp.NfpManager;
using System.Text.Json.Serialization;

namespace Trijinx.HLE.HOS.Services.Nfc.Nfp
{
    [JsonSerializable(typeof(VirtualAmiiboFile))]
    internal partial class AmiiboJsonSerializerContext : JsonSerializerContext
    {
    }
}

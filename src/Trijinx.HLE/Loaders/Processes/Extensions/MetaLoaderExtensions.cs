using LibHac.Loader;
using Trijinx.Common;

namespace Trijinx.HLE.Loaders.Processes.Extensions
{
    public static class MetaLoaderExtensions
    {
        public static void LoadDefault(this MetaLoader metaLoader)
        {
            byte[] npdmBuffer = EmbeddedResources.Read("Trijinx.HLE/Homebrew.npdm");

            metaLoader.Load(npdmBuffer).ThrowIfFailure();
        }
    }
}

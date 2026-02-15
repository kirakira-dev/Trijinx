using System.Collections.Generic;

namespace Trijinx.Common.Configuration
{
    public struct ModMetadata
    {
        public List<Mod> Mods { get; set; }

        public ModMetadata()
        {
            Mods = [];
        }
    }
}

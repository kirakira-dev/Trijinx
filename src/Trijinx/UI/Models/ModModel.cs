using CommunityToolkit.Mvvm.ComponentModel;
using Trijinx.Ava.UI.ViewModels;
using System.Globalization;

namespace Trijinx.Ava.UI.Models
{
    public partial class ModModel : BaseModel
    {
        [ObservableProperty]
        public partial bool Enabled { get; set; }
        public bool InSd { get; }
        public string Path { get; }
        public string Name { get; }

        public string FormattedName =>
            InSd && ulong.TryParse(Name, NumberStyles.HexNumber, null, out ulong applicationId)
                ? $"Atmosphère: {TrijinxApp.MainWindow.ApplicationLibrary.GetNameForApplicationId(applicationId)}"
                : Name;

        public ModModel(string path, string name, bool enabled, bool inSd)
        {
            Path = path;
            Name = name;
            Enabled = enabled;
            InSd = inSd;
        }
    }
}

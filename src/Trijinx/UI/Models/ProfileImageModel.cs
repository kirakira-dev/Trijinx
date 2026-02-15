using Avalonia.Media;
using CommunityToolkit.Mvvm.ComponentModel;
using Trijinx.Ava.UI.ViewModels;

namespace Trijinx.Ava.UI.Models
{
    public partial class ProfileImageModel : BaseModel
    {
        public ProfileImageModel(string name, byte[] data)
        {
            Name = name;
            Data = data;
        }

        public string Name { get; set; }
        public byte[] Data { get; set; }

        [ObservableProperty]
        public partial SolidColorBrush BackgroundColor { get; set; } = new(Colors.White);
    }
}

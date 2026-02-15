using CommunityToolkit.Mvvm.ComponentModel;

namespace Trijinx.Ava.UI.ViewModels
{
    public partial class UserProfileImageSelectorViewModel : BaseModel
    {
        [ObservableProperty]
        public partial bool FirmwareFound { get; set; }
    }
}

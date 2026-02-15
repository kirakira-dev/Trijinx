using CommunityToolkit.Mvvm.ComponentModel;
using Trijinx.HLE.HOS.Services.Account.Acc;
using System.Collections.ObjectModel;

namespace Trijinx.Ava.UI.ViewModels
{
    public partial class ProfileSelectorDialogViewModel : BaseModel
    {

        [ObservableProperty]
        public partial UserId SelectedUserId { get; set; }

        [ObservableProperty]
        public partial ObservableCollection<BaseModel> Profiles { get; set; } = [];
    }
}

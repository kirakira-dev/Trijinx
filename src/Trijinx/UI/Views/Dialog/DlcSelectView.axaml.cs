using FluentAvalonia.UI.Controls;
using Trijinx.Ava.Common.Locale;
using Trijinx.Ava.Common.Models;
using Trijinx.Ava.Systems.AppLibrary;
using Trijinx.Ava.UI.Controls;
using Trijinx.Ava.UI.Helpers;
using Trijinx.Ava.UI.ViewModels;
using System.Threading.Tasks;

namespace Trijinx.Ava.UI.Views.Dialog
{
    public partial class DlcSelectView : TrijinxControl<DlcSelectViewModel>
    {
        public DlcSelectView()
        {
            InitializeComponent();
        }

#nullable enable
        public static async Task<DownloadableContentModel?> Show(ulong selectedTitleId, ApplicationLibrary appLibrary)
#nullable disable
        {
            DlcSelectViewModel viewModel = new(selectedTitleId, appLibrary);

            ContentDialog contentDialog = new()
            {
                PrimaryButtonText = LocaleManager.Instance[LocaleKeys.Continue],
                SecondaryButtonText = string.Empty,
                CloseButtonText = string.Empty,
                Content = new DlcSelectView { ViewModel = viewModel }
            };

            await ContentDialogHelper.ShowAsync(contentDialog.ApplyStyles());

            return viewModel.SelectedDlc;
        }
    }
}

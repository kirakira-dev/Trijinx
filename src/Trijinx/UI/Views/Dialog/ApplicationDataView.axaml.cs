using Avalonia.Controls;
using Avalonia.Input.Platform;
using Avalonia.Interactivity;
using Avalonia.Layout;
using FluentAvalonia.UI.Controls;
using Trijinx.Ava.Common.Locale;
using Trijinx.Ava.Systems.AppLibrary;
using Trijinx.Ava.UI.Controls;
using Trijinx.Ava.UI.Helpers;
using Trijinx.Ava.UI.ViewModels;
using Trijinx.Ava.UI.Windows;
using System.Linq;
using System.Threading.Tasks;

namespace Trijinx.Ava.UI.Views.Dialog
{
    public partial class ApplicationDataView : TrijinxControl<ApplicationDataViewModel>
    {
        public static async Task Show(ApplicationData appData)
        {
            ContentDialog contentDialog = new()
            {
                Title = appData.Name,
                PrimaryButtonText = string.Empty,
                SecondaryButtonText = string.Empty,
                CloseButtonText = LocaleManager.Instance[LocaleKeys.SettingsButtonClose],
                MinWidth = 256,
                Content = new ApplicationDataView { ViewModel = new ApplicationDataViewModel(appData) }
            };

            await ContentDialogHelper.ShowAsync(contentDialog.ApplyStyles(160, HorizontalAlignment.Center));
        }

        public ApplicationDataView()
        {
            InitializeComponent();
        }

        private async void PlayabilityStatus_OnClick(object sender, RoutedEventArgs e)
        {
            if (sender is not Button { Content: TextBlock playabilityLabel })
                return;

            if (TrijinxApp.AppLifetime.Windows.TryGetFirst(x => x is ContentDialogOverlayWindow, out Window window))
                window.Close(ContentDialogResult.None);

            await CompatibilityListWindow.Show((string)playabilityLabel.Tag);
        }

        private async void IdString_OnClick(object sender, RoutedEventArgs e)
        {
            if (sender is not Button { Content: TextBlock idText })
                return;

            if (!TrijinxApp.IsClipboardAvailable(out IClipboard clipboard))
                return;

            ApplicationData appData = TrijinxApp.MainWindow.ViewModel.Applications.FirstOrDefault(it => it.IdString == idText.Text);
            if (appData is null)
                return;

            await clipboard.SetTextAsync(appData.IdString);

            NotificationHelper.ShowInformation(
                "Copied Title ID",
                $"{appData.Name} ({appData.IdString})");
        }
    }
}


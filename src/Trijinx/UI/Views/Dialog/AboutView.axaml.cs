using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using FluentAvalonia.UI.Controls;
using Trijinx.Ava.Common.Locale;
using Trijinx.Ava.UI.Controls;
using Trijinx.Ava.UI.Helpers;
using Trijinx.Ava.UI.ViewModels;
using Trijinx.Common.Helper;
using System.Threading.Tasks;
using Button = Avalonia.Controls.Button;

namespace Trijinx.Ava.UI.Views.Dialog
{
    public partial class AboutView : TrijinxControl<AboutWindowViewModel>
    {
        public AboutView()
        {
            InitializeComponent();
        }

        public static async Task Show()
        {
            using AboutWindowViewModel viewModel = new();

            ContentDialog contentDialog = new()
            {
                PrimaryButtonText = string.Empty,
                SecondaryButtonText = string.Empty,
                CloseButtonText = LocaleManager.Instance[LocaleKeys.UserProfilesClose],
                Content = new AboutView { ViewModel = viewModel }
            };

            await ContentDialogHelper.ShowAsync(contentDialog.ApplyStyles());
        }

        private void Button_OnClick(object sender, RoutedEventArgs e)
        {
            if (sender is Button { Tag: string url })
                OpenHelper.OpenUrl(url);
        }

        private void AmiiboLabel_OnPointerPressed(object sender, PointerPressedEventArgs e)
        {
            if (sender is TextBlock)
            {
                OpenHelper.OpenUrl("https://amiiboapi.com");
            }
        }
    }
}

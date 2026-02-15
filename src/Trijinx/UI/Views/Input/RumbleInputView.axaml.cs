using FluentAvalonia.UI.Controls;
using Trijinx.Ava.Common.Locale;
using Trijinx.Ava.UI.Controls;
using Trijinx.Ava.UI.Models.Input;
using Trijinx.Ava.UI.ViewModels.Input;
using System.Threading.Tasks;

namespace Trijinx.Ava.UI.Views.Input
{
    public partial class RumbleInputView : TrijinxControl<RumbleInputViewModel>
    {
        public RumbleInputView()
        {
            InitializeComponent();
        }

        public RumbleInputView(ControllerInputViewModel viewModel)
        {
            GamepadInputConfig config = viewModel.Config;

            ViewModel = new RumbleInputViewModel
            {
                StrongRumble = config.StrongRumble,
                WeakRumble = config.WeakRumble,
            };

            InitializeComponent();
        }

        public static async Task Show(ControllerInputViewModel viewModel)
        {
            RumbleInputView content = new(viewModel);

            ContentDialog contentDialog = new()
            {
                Title = LocaleManager.Instance[LocaleKeys.ControllerRumbleTitle],
                PrimaryButtonText = LocaleManager.Instance[LocaleKeys.ControllerSettingsSave],
                SecondaryButtonText = string.Empty,
                CloseButtonText = LocaleManager.Instance[LocaleKeys.ControllerSettingsClose],
                Content = content,
            };

            contentDialog.PrimaryButtonClick += (_, _) =>
            {
                GamepadInputConfig config = viewModel.Config;
                config.StrongRumble = content.ViewModel.StrongRumble;
                config.WeakRumble = content.ViewModel.WeakRumble;
            };

            await contentDialog.ShowAsync();
        }
    }
}

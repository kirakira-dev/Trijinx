using Avalonia.Controls;
using FluentAvalonia.UI.Controls;
using Trijinx.Ava.Common.Locale;
using Trijinx.Ava.Systems.Configuration;
using Trijinx.Ava.UI.Controls;
using Trijinx.Ava.UI.Helpers;
using Trijinx.Ava.UI.Models;
using Trijinx.Ava.UI.ViewModels.Input;

namespace Trijinx.Ava.UI.Views.Input
{
    public partial class InputView : TrijinxControl<InputViewModel>
    {
        private bool _dialogOpen;

        public InputView()
        {
            ViewModel = new InputViewModel(this, ConfigurationState.Instance.System.UseInputGlobalConfig);

            InitializeComponent();
        }

        public void SaveCurrentProfile()
        {
            ViewModel.Save();
        }

        public void ToggleLocalGlobalInput(bool enableConfigGlobal)
        {
            Dispose();
            ViewModel = new InputViewModel(this, enableConfigGlobal); // Create new Input Page with global input configs
            InitializeComponent();
        }

        private async void PlayerIndexBox_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (PlayerIndexBox != null)
            {
                if (PlayerIndexBox.SelectedIndex != (int)ViewModel.PlayerId)
                {
                    PlayerIndexBox.SelectedIndex = (int)ViewModel.PlayerId;
                }
            }

            if (ViewModel.IsModified && !_dialogOpen)
            {
                _dialogOpen = true;

                UserResult result = await ContentDialogHelper.CreateDeniableConfirmationDialog(
                    LocaleManager.Instance[LocaleKeys.DialogControllerSettingsModifiedConfirmMessage],
                    LocaleManager.Instance[LocaleKeys.DialogControllerSettingsModifiedConfirmSubMessage],
                    LocaleManager.Instance[LocaleKeys.InputDialogYes],
                    LocaleManager.Instance[LocaleKeys.InputDialogNo],
                    LocaleManager.Instance[LocaleKeys.Cancel],
                    LocaleManager.Instance[LocaleKeys.TrijinxConfirm]);

                if (result == UserResult.Yes)
                {
                    ViewModel.Save();
                }

                _dialogOpen = false;

                if (result == UserResult.Cancel)
                {
                    if (e.AddedItems.Count > 0)
                    {
                        ViewModel.IsModified = true;
                        ViewModel.PlayerId = ((PlayerModel)e.AddedItems[0])!.Id;
                    }

                    return;
                }

                ViewModel.IsModified = false;
                ViewModel.PlayerId = ViewModel.PlayerIdChoose;

            }
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (sender is FAComboBox faComboBox)
            {
                faComboBox.IsDropDownOpen = false;
                ViewModel.IsModified = true;
            }
        }

        public void Dispose()
        {
            ViewModel.Dispose();
        }
    }
}

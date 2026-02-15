using Avalonia.Controls;
using Trijinx.Ava.UI.Controls;
using Trijinx.Ava.UI.ViewModels;
using TimeZone = Trijinx.Ava.UI.Models.TimeZone;

namespace Trijinx.Ava.UI.Views.Settings
{
    public partial class SettingsSystemView : TrijinxControl<SettingsViewModel>
    {
        public SettingsSystemView()
        {
            InitializeComponent();
        }

        private void TimeZoneBox_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems != null && e.AddedItems.Count > 0)
            {
                if (e.AddedItems[0] is TimeZone timeZone)
                {
                    e.Handled = true;

                    ViewModel.ValidateAndSetTimeZone(timeZone.Location);
                }
            }
        }

        private void TimeZoneBox_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender is AutoCompleteBox box && box.SelectedItem is TimeZone timeZone)
            {
                ViewModel.ValidateAndSetTimeZone(timeZone.Location);
            }
        }
    }
}

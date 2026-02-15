using Avalonia.Controls;

namespace Trijinx.Ava.UI.Views.Settings
{
    public partial class SettingsInputView : UserControl
    {
        public SettingsInputView()
        {
            InitializeComponent();
        }

        public void Dispose()
        {
            InputView.Dispose();
        }
    }
}

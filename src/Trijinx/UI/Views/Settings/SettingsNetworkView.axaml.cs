using Avalonia.Interactivity;
using Trijinx.Ava.UI.Controls;
using Trijinx.Ava.UI.ViewModels;
using System;

namespace Trijinx.Ava.UI.Views.Settings
{
    public partial class SettingsNetworkView : TrijinxControl<SettingsViewModel>
    {
        private readonly Random _random;

        public SettingsNetworkView()
        {
            _random = new Random();
            InitializeComponent();
        }

        private void GenLdnPassButton_OnClick(object sender, RoutedEventArgs e)
        {
            byte[] code = new byte[4];
            _random.NextBytes(code);
            ViewModel.LdnPassphrase = $"Trijinx-{BitConverter.ToUInt32(code):x8}";
        }

        private void ClearLdnPassButton_OnClick(object sender, RoutedEventArgs e)
        {
            ViewModel.LdnPassphrase = string.Empty;
        }
    }
}

using Avalonia.Controls;
using FluentAvalonia.UI.Controls;
using Trijinx.Ava.Common.Locale;
using Trijinx.Ava.Systems.Configuration;
using Trijinx.Ava.UI.ViewModels;
using Trijinx.HLE.FileSystem;
using Trijinx.Input;
using System;
using System.Linq;

namespace Trijinx.Ava.UI.Windows
{
    public partial class SettingsWindow : StyleableAppWindow
    {
        internal readonly SettingsViewModel ViewModel;

        public SettingsWindow(VirtualFileSystem virtualFileSystem, ContentManager contentManager) : base(true)
        {
            Title = TrijinxApp.FormatTitle(LocaleKeys.Settings);

            DataContext = ViewModel = new SettingsViewModel(virtualFileSystem, contentManager);

            ViewModel.CloseWindow += Close;
            ViewModel.SaveSettingsEvent += SaveSettings;

            InitializeComponent();

            NavPanel.PaneDisplayMode =
                ConfigurationState.Instance.ShowOldUI
                    ? NavigationViewPaneDisplayMode.Left
                    : NavigationViewPaneDisplayMode.Top;

            Height = ConfigurationState.Instance.ShowOldUI
                ? 906
                : 954; // nav panel is put on top with custom title bar so account for new height

            Load();
        }

        public SettingsWindow()
        {
            DataContext = ViewModel = new SettingsViewModel();

            InitializeComponent();
            Load();
        }

        public void SaveSettings()
        {
            InputPage.InputView?.SaveCurrentProfile();

            if (Owner is MainWindow window && ViewModel.GameListNeedsRefresh)
            {
                window.LoadApplications();
            }
        }

        private void Load()
        {
            Pages.Children.Clear();
            NavPanel.SelectionChanged += NavPanelOnSelectionChanged;
            NavPanel.SelectedItem = NavPanel.MenuItems.ElementAt(0);
        }

        private void NavPanelOnSelectionChanged(object sender, NavigationViewSelectionChangedEventArgs e)
        {
            if (e.SelectedItem is NavigationViewItem navItem && navItem.Tag is not null)
            {
                switch (navItem.Tag.ToString())
                {
                    case "UiPage":
                        UiPage.ViewModel = ViewModel;
                        NavPanel.Content = UiPage;
                        break;
                    case "InputPage":
                        NavPanel.Content = InputPage;
                        break;
                    case "HotkeysPage":
                        NavPanel.Content = HotkeysPage;
                        break;
                    case "SystemPage":
                        SystemPage.ViewModel = ViewModel;
                        NavPanel.Content = SystemPage;
                        break;
                    case "CpuPage":
                        NavPanel.Content = CpuPage;
                        break;
                    case "GraphicsPage":
                        NavPanel.Content = GraphicsPage;
                        break;
                    case "AudioPage":
                        NavPanel.Content = AudioPage;
                        break;
                    case "NetworkPage":
                        NetworkPage.ViewModel = ViewModel;
                        NavPanel.Content = NetworkPage;
                        break;
                    case "LoggingPage":
                        NavPanel.Content = LoggingPage;
                        break;
                    case "DebugPage":
                        NavPanel.Content = DebugPage;
                        break;
                    case nameof(HacksPage):
                        HacksPage.DataContext = ViewModel;
                        NavPanel.Content = HacksPage;
                        break;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        protected override void OnClosing(WindowClosingEventArgs e)
        {
            HotkeysPage.Dispose();

            foreach (IGamepad gamepad in TrijinxApp.MainWindow.InputManager.GamepadDriver.GetGamepads())
            {
                gamepad?.ClearLed();
            }

            InputPage.Dispose();
            base.OnClosing(e);
        }
    }
}

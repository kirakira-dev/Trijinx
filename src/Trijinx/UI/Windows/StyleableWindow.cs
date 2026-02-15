using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Input;
using Avalonia.Media;
using Avalonia.Platform;
using FluentAvalonia.UI.Windowing;
using Trijinx.Ava.Common.Locale;
using Trijinx.Ava.Systems.Configuration;
using Trijinx.Ava.UI.Controls;
using System.Threading.Tasks;

namespace Trijinx.Ava.UI.Windows
{
    public abstract class StyleableAppWindow : AppWindow
    {
        public static async Task ShowAsync(StyleableAppWindow appWindow, Window owner = null)
        {
#if DEBUG
            appWindow.AttachDevTools(new KeyGesture(Key.F12, KeyModifiers.Control));
#endif
            await appWindow.ShowDialog(owner ?? TrijinxApp.MainWindow);
        }

        protected StyleableAppWindow(bool useCustomTitleBar = false, double? titleBarHeight = null)
        {
            WindowStartupLocation = WindowStartupLocation.CenterOwner;
            TransparencyLevelHint = [WindowTransparencyLevel.None];

            LocaleManager.Instance.LocaleChanged += LocaleChanged;
            LocaleChanged();

            if (useCustomTitleBar)
            {
                TitleBar.ExtendsContentIntoTitleBar = !ConfigurationState.Instance.ShowOldUI;
                TitleBar.TitleBarHitTestType = ConfigurationState.Instance.ShowOldUI ? TitleBarHitTestType.Simple : TitleBarHitTestType.Complex;

                if (TitleBar.ExtendsContentIntoTitleBar && titleBarHeight != null)
                    TitleBar.Height = titleBarHeight.Value;
            }

            Icon = TrijinxLogo.Bitmap;
        }

        private void LocaleChanged()
        {
            FlowDirection = LocaleManager.Instance.IsRTL() ? FlowDirection.RightToLeft : FlowDirection.LeftToRight;
        }

        protected override void OnApplyTemplate(TemplateAppliedEventArgs e)
        {
            base.OnApplyTemplate(e);

            ExtendClientAreaChromeHints = ExtendClientAreaChromeHints.SystemChrome | ExtendClientAreaChromeHints.OSXThickTitleBar;
        }
    }

    public abstract class StyleableWindow : Window
    {
        public static async Task ShowAsync(StyleableWindow window, Window owner = null)
        {
#if DEBUG
            window.AttachDevTools(new KeyGesture(Key.F12, KeyModifiers.Control));
#endif
            await window.ShowDialog(owner ?? TrijinxApp.MainWindow);
        }

        protected StyleableWindow()
        {
            WindowStartupLocation = WindowStartupLocation.CenterOwner;
            TransparencyLevelHint = [WindowTransparencyLevel.None];

            LocaleManager.Instance.LocaleChanged += LocaleChanged;
            LocaleChanged();

            Icon = new WindowIcon(TrijinxLogo.Bitmap);
        }

        private void LocaleChanged()
        {
            FlowDirection = LocaleManager.Instance.IsRTL() ? FlowDirection.RightToLeft : FlowDirection.LeftToRight;
        }

        protected override void OnApplyTemplate(TemplateAppliedEventArgs e)
        {
            base.OnApplyTemplate(e);

            ExtendClientAreaChromeHints = ExtendClientAreaChromeHints.SystemChrome | ExtendClientAreaChromeHints.OSXThickTitleBar;
        }
    }
}

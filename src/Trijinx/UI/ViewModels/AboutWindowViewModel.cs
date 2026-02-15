using Avalonia.Media.Imaging;
using Avalonia.Styling;
using Avalonia.Threading;
using CommunityToolkit.Mvvm.ComponentModel;
using Gommon;
using Trijinx.Ava.Common.Locale;
using Trijinx.Ava.Systems.Configuration;
using System;

namespace Trijinx.Ava.UI.ViewModels
{
    public partial class AboutWindowViewModel : BaseModel, IDisposable
    {
        [ObservableProperty] public partial Bitmap GitLabLogo { get; set; }

        [ObservableProperty] public partial Bitmap DiscordLogo { get; set; }

        [ObservableProperty] public partial string Version { get; set; }

        public static string Developers => "GreemDev, LotP";

        public static string FormerDevelopers => LocaleManager.Instance.UpdateAndGetDynamicValue(
            LocaleKeys.AboutPageDeveloperListMore,
            "gdkchan, Ac_K, marysaka, rip in peri peri, LDj3SNuD, emmaus, Thealexbarney, GoffyDude, TSRBerry, IsaacMarovitz");

        public AboutWindowViewModel()
        {
            Version = TrijinxApp.FullAppName + "\n" + Program.Version;
            UpdateLogoTheme(ConfigurationState.Instance.UI.BaseStyle.Value);

            TrijinxApp.ThemeChanged += Trijinx_ThemeChanged;
        }

        private void Trijinx_ThemeChanged()
        {
            Dispatcher.UIThread.Post(() => UpdateLogoTheme(ConfigurationState.Instance.UI.BaseStyle.Value));
        }

        private const string LogoPathFormat = "resm:Trijinx.Assets.UIImages.Logo_{0}_{1}.png?assembly=Trijinx";

        private void UpdateLogoTheme(string theme)
        {
            bool isDarkTheme = theme == "Dark" ||
                               (theme == "Auto" && TrijinxApp.DetectSystemTheme() == ThemeVariant.Dark);

            string themeName = isDarkTheme ? "Dark" : "Light";

            DiscordLogo = LoadBitmap(LogoPathFormat.Format("Discord", themeName));
            GitLabLogo = LoadBitmap(LogoPathFormat.Format("GitLab", themeName));
        }

        private static Bitmap LoadBitmap(string uri) => new(Avalonia.Platform.AssetLoader.Open(new Uri(uri)));

        public void Dispose()
        {
            TrijinxApp.ThemeChanged -= Trijinx_ThemeChanged;

            GitLabLogo.Dispose();
            DiscordLogo.Dispose();

            GC.SuppressFinalize(this);
        }
    }
}

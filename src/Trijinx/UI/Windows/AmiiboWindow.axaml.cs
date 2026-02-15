using Avalonia.Interactivity;
using Trijinx.Ava.Common.Locale;
using Trijinx.Ava.Common.Models.Amiibo;
using Trijinx.Ava.Systems.Configuration;
using Trijinx.Ava.UI.ViewModels;

namespace Trijinx.Ava.UI.Windows
{
    public partial class AmiiboWindow : StyleableAppWindow
    {
        public AmiiboWindow(bool showAll, string lastScannedAmiiboId, string titleId) : base(true, 40)
        {
            DataContext = ViewModel = new AmiiboWindowViewModel(this, lastScannedAmiiboId, titleId)
            {
                ShowAllAmiibo = showAll,
            };

            InitializeComponent();

            FlushControls.IsVisible = !ConfigurationState.Instance.ShowOldUI;
            NormalControls.IsVisible = ConfigurationState.Instance.ShowOldUI;

            Title = TrijinxApp.FormatTitle(LocaleKeys.Amiibo);
        }

        public AmiiboWindow()
        {
            DataContext = ViewModel = new AmiiboWindowViewModel(this, string.Empty, string.Empty);

            InitializeComponent();

            if (Program.PreviewerDetached)
            {
                Title = TrijinxApp.FormatTitle(LocaleKeys.Amiibo);
            }
        }

        public bool IsScanned { get; set; }
        public AmiiboApi ScannedAmiibo { get; set; }
        public AmiiboWindowViewModel ViewModel;

        private void ScanButton_Click(object sender, RoutedEventArgs e) => ViewModel.Scan();

        private void CancelButton_Click(object sender, RoutedEventArgs e) => ViewModel.Cancel();
    }
}

using Avalonia.Controls;
using Trijinx.Ava.Common.Locale;
using Avalonia.Interactivity;
using Trijinx.Ava.Systems.Configuration;
using Trijinx.Ava.UI.ViewModels;
using System.Threading.Tasks;

namespace Trijinx.Ava.UI.Windows
{
    public partial class CompatibilityListWindow : StyleableAppWindow
    {
        public static async Task Show(string titleId = null)
        {
            using CompatibilityViewModel compatWindow = new(TrijinxApp.MainWindow.ViewModel.ApplicationLibrary);

            await ShowAsync(new CompatibilityListWindow
            {
                DataContext = compatWindow,
                SearchBoxFlush = { Text = titleId ?? string.Empty },
                SearchBoxNormal = { Text = titleId ?? string.Empty }
            });
        }

        public CompatibilityListWindow() : base(useCustomTitleBar: true, 37)
        {
            Title = TrijinxApp.FormatTitle(LocaleKeys.CompatibilityListTitle);

            InitializeComponent();

            FlushControls.IsVisible = !ConfigurationState.Instance.ShowOldUI;
            NormalControls.IsVisible = ConfigurationState.Instance.ShowOldUI;
        }

        // ReSharper disable once UnusedMember.Local
        // its referenced in the axaml but rider keeps yelling at me that its unused so
        private void TextBox_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            if (DataContext is not CompatibilityViewModel cvm)
                return;

            if (sender is not TextBox searchBox)
                return;

            cvm.Search(searchBox.Text);
        }

        public void Sort_Name_Checked(object sender, RoutedEventArgs args)
        {
            if (sender is RadioButton { Tag: string sortStrategy })
            {
                if (DataContext is not CompatibilityViewModel cvm)
                    return;

                cvm.NameSorting(int.Parse(sortStrategy));
            }
        }

        public void Sort_Status_Checked(object sender, RoutedEventArgs args)
        {
            if (sender is RadioButton { Tag: string sortStrategy })
            {
                if (DataContext is not CompatibilityViewModel cvm)
                    return;

                cvm.StatusSorting(int.Parse(sortStrategy));
            }
        }
    }
}

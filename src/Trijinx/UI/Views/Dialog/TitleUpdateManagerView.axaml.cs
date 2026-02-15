using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Styling;
using FluentAvalonia.UI.Controls;
using Trijinx.Ava.Common.Locale;
using Trijinx.Ava.Common.Models;
using Trijinx.Ava.Systems.AppLibrary;
using Trijinx.Ava.UI.Controls;
using Trijinx.Ava.UI.ViewModels;
using Trijinx.Common.Helper;
using System.Threading.Tasks;

namespace Trijinx.Ava.UI.Views.Dialog
{
    public partial class TitleUpdateManagerView : TrijinxControl<TitleUpdateViewModel>
    {
        public TitleUpdateManagerView()
        {
            InitializeComponent();
        }

        public static async Task Show(ApplicationLibrary applicationLibrary, ApplicationData applicationData)
        {
            ContentDialog contentDialog = new()
            {
                PrimaryButtonText = string.Empty,
                SecondaryButtonText = string.Empty,
                CloseButtonText = string.Empty,
                Title = LocaleManager.Instance.UpdateAndGetDynamicValue(LocaleKeys.GameUpdateWindowHeading, applicationData.Name, applicationData.IdBaseString),
                Content = new TitleUpdateManagerView
                {
                    ViewModel = new TitleUpdateViewModel(applicationLibrary, applicationData)
                }
            };

            Style bottomBorder = new(x => x.OfType<Grid>().Name("DialogSpace").Child().OfType<Border>());
            bottomBorder.Setters.Add(new Setter(IsVisibleProperty, false));

            contentDialog.Styles.Add(bottomBorder);

            await contentDialog.ShowAsync();
        }

        private void Close(object sender, RoutedEventArgs e)
        {
            ((ContentDialog)Parent).Hide();
        }

        public void Save(object sender, RoutedEventArgs e)
        {
            ViewModel.Save();

            ((ContentDialog)Parent).Hide();
        }

        private void OpenLocation(object sender, RoutedEventArgs e)
        {
            if (sender is Button { DataContext: TitleUpdateModel model })
                OpenHelper.LocateFile(model.Path);
        }

        private void RemoveUpdate(object sender, RoutedEventArgs e)
        {
            if (sender is Button { DataContext: TitleUpdateModel model })
                ViewModel.RemoveUpdate(model);
        }

        private void RemoveAll(object sender, RoutedEventArgs e)
        {
            ViewModel.TitleUpdates.Clear();

            ViewModel.SortUpdates();
        }
    }
}

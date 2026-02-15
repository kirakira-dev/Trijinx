using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Styling;
using FluentAvalonia.UI.Controls;
using Trijinx.Ava.Common.Locale;
using Trijinx.Ava.Common.Models;
using Trijinx.Ava.UI.Controls;
using Trijinx.Ava.UI.ViewModels;
using System;
using System.Threading.Tasks;

namespace Trijinx.Ava.UI.Views.Dialog
{
    public partial class XciTrimmerView : TrijinxControl<XciTrimmerViewModel>
    {
        public XciTrimmerView()
        {
            InitializeComponent();
        }

        public static async Task Show()
        {
            ContentDialog contentDialog = new()
            {
                PrimaryButtonText = string.Empty,
                SecondaryButtonText = string.Empty,
                CloseButtonText = string.Empty,
                Content = new XciTrimmerView
                {
                    ViewModel = new XciTrimmerViewModel(TrijinxApp.MainWindow.ViewModel)
                },
                Title = LocaleManager.Instance[LocaleKeys.XCITrimmerWindowTitle]
            };

            Style bottomBorder = new(x => x.OfType<Grid>().Name("DialogSpace").Child().OfType<Border>());
            bottomBorder.Setters.Add(new Setter(IsVisibleProperty, false));

            contentDialog.Styles.Add(bottomBorder);

            await contentDialog.ShowAsync();
        }

        private void Trim(object sender, RoutedEventArgs e)
        {
            ViewModel.TrimSelected();
        }

        private void Untrim(object sender, RoutedEventArgs e)
        {
            ViewModel.UntrimSelected();
        }

        private void Close(object sender, RoutedEventArgs e)
        {
            ((ContentDialog)Parent).Hide();
        }

        private void Cancel(Object sender, RoutedEventArgs e)
        {
            ViewModel.Cancel = true;
        }

        public void Sort_Checked(object sender, RoutedEventArgs args)
        {
            if (sender is RadioButton { Tag: string sortField })
                ViewModel.SortingField = Enum.Parse<XciTrimmerViewModel.SortField>(sortField);
        }

        public void Order_Checked(object sender, RoutedEventArgs args)
        {
            if (sender is RadioButton { Tag: string sortOrder })
                ViewModel.SortingAscending = sortOrder is "Ascending";
        }

        private void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            foreach (object content in e.AddedItems)
            {
                if (content is XCITrimmerFileModel applicationData)
                {
                    ViewModel.Select(applicationData);
                }
            }

            foreach (object content in e.RemovedItems)
            {
                if (content is XCITrimmerFileModel applicationData)
                {
                    ViewModel.Deselect(applicationData);
                }
            }
        }
    }
}

using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using Trijinx.Ava.Common;
using Trijinx.Ava.UI.Controls;
using Trijinx.Ava.UI.ViewModels;
using Trijinx.Ava.UI.Windows;
using System;

namespace Trijinx.Ava.UI.Views.Main
{
    public partial class MainViewControls : TrijinxControl<MainWindowViewModel>
    {
        public MainViewControls()
        {
            InitializeComponent();
        }

        protected override void OnAttachedToVisualTree(VisualTreeAttachmentEventArgs e)
        {
            base.OnAttachedToVisualTree(e);

            if (VisualRoot is MainWindow window)
            {
                ViewModel = window.ViewModel;
            }
        }

        public void Sort_Checked(object sender, RoutedEventArgs args)
        {
            if (sender is RadioButton { Tag: string sortStrategy })
                ViewModel.Sort(Enum.Parse<ApplicationSort>(sortStrategy));
        }

        public void Order_Checked(object sender, RoutedEventArgs args)
        {
            if (sender is RadioButton { Tag: string sortOrder })
                ViewModel.Sort(sortOrder is not "Descending");
        }

        private void SearchBox_OnKeyUp(object sender, KeyEventArgs e)
        {
            ViewModel.SearchText = SearchBox.Text;
        }
    }
}

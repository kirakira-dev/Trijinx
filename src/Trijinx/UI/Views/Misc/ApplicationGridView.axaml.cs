using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using Trijinx.Ava.Systems.AppLibrary;
using Trijinx.Ava.UI.Controls;
using Trijinx.Ava.UI.Helpers;
using Trijinx.Ava.UI.ViewModels;
using System;

namespace Trijinx.Ava.UI.Views.Misc
{
    public partial class ApplicationGridView : TrijinxControl<MainWindowViewModel>
    {
        public static readonly RoutedEvent<ApplicationOpenedEventArgs> ApplicationOpenedEvent =
            RoutedEvent.Register<ApplicationGridView, ApplicationOpenedEventArgs>(nameof(ApplicationOpened), RoutingStrategies.Bubble);

        public event EventHandler<ApplicationOpenedEventArgs> ApplicationOpened
        {
            add => AddHandler(ApplicationOpenedEvent, value);
            remove => RemoveHandler(ApplicationOpenedEvent, value);
        }

        public ApplicationGridView() => InitializeComponent();

        public void GameList_DoubleTapped(object sender, TappedEventArgs args)
        {
            if (sender is ListBox { SelectedItem: ApplicationData selected })
                RaiseEvent(new ApplicationOpenedEventArgs(selected, ApplicationOpenedEvent));
        }
    }
}

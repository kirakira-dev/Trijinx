using Avalonia.Interactivity;
using Trijinx.Ava.Systems.AppLibrary;

namespace Trijinx.Ava.UI.Helpers
{
    public class ApplicationOpenedEventArgs : RoutedEventArgs
    {
        public ApplicationData Application { get; }

        public ApplicationOpenedEventArgs(ApplicationData application, RoutedEvent routedEvent)
        {
            Application = application;
            RoutedEvent = routedEvent;
        }
    }
}

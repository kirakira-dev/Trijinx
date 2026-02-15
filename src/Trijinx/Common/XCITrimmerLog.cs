using Avalonia.Threading;
using Trijinx.Ava.UI.ViewModels;

namespace Trijinx.Ava.Common
{
    public static class XCITrimmerLog
    {
        internal class MainWindow : Trijinx.Common.Logging.XCIFileTrimmerLog
        {
            private readonly MainWindowViewModel _viewModel;

            public MainWindow(MainWindowViewModel viewModel)
            {
                _viewModel = viewModel;
            }

            public override void Progress(long current, long total, string text, bool complete)
            {
                Dispatcher.UIThread.Post(() =>
                {
                    _viewModel.StatusBarProgressMaximum = (int)(total);
                    _viewModel.StatusBarProgressValue = (int)(current);
                });
            }
        }

        internal class TrimmerWindow : Trijinx.Common.Logging.XCIFileTrimmerLog
        {
            private readonly XciTrimmerViewModel _viewModel;

            public TrimmerWindow(XciTrimmerViewModel viewModel)
            {
                _viewModel = viewModel;
            }

            public override void Progress(long current, long total, string text, bool complete)
            {
                Dispatcher.UIThread.Post(() =>
                {
                    _viewModel.SetProgress((int)(current), (int)(total));
                });
            }
        }
    }
}

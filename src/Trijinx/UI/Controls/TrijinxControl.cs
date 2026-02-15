using Avalonia.Controls;
using Gommon;
using Trijinx.Ava.UI.ViewModels;
using System;

namespace Trijinx.Ava.UI.Controls
{
    public class TrijinxControl<TViewModel> : UserControl where TViewModel : BaseModel
    {
        public TViewModel ViewModel
        {
            get
            {
                if (DataContext is not TViewModel viewModel)
                    throw new InvalidOperationException(
                        $"Underlying DataContext is not of type {typeof(TViewModel).AsPrettyString()}; " +
                        $"Actual type is {DataContext?.GetType().AsPrettyString()}");

                return viewModel;
            }
            set => DataContext = value;
        }
    }
}

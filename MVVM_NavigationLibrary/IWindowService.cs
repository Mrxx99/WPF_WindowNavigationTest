using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfUI
{
    public interface IWindowService
    {
        IWindow GetWindow<TViewModelWindow>(TViewModelWindow viewModel) where TViewModelWindow : IViewModelWindow;

        IWindow ShowWindow<TViewModelWindow>(TViewModelWindow viewModel) where TViewModelWindow : IViewModelWindow;
    }
}

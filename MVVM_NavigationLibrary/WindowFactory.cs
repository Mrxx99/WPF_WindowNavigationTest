using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfUI
{
    public class WindowFactory : IWindowFactory, IWindowService
    {
        private Dictionary<Type, Type> viewModelToViewAssociations = new Dictionary<Type, Type>();

        public WindowFactory RegisterWindow<TViewModelWindow, TWindow>() where TViewModelWindow : IViewModelWindow where TWindow : IWindow, new()
        {
            viewModelToViewAssociations.Add(typeof(TViewModelWindow), typeof(TWindow));

            return this;
        }

        public IWindow GetWindow<TViewModelWindow>(TViewModelWindow viewModel) where TViewModelWindow : IViewModelWindow
        {
            var windowType = viewModelToViewAssociations[typeof(TViewModelWindow)];

            var window = (IWindow)Activator.CreateInstance(windowType);

            var windowWrapper = new WindowWrapper(this, window, viewModel);

            return windowWrapper;
        }

        public IWindow ShowWindow<TViewModelWindow>(TViewModelWindow viewModel) where TViewModelWindow : IViewModelWindow
        {
            var window = GetWindow(viewModel);
            window.Show();
            return window;
        }
    }
}

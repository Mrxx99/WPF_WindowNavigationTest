using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfUI
{
    public class WindowWrapper : IWindow
    {
        private readonly Window window;
        private readonly IWindowService windowFactory;

        public object DataContext { get; }

        public WindowWrapper(IWindowService windowFactory, Window window)
        {
            this.windowFactory = windowFactory;
            this.window = window;
        }

        public WindowWrapper(IWindowService windowFactory, Window window, IViewModelWindow datacontext)
        {
            this.windowFactory = windowFactory;
            this.window = window;
            this.window.DataContext = datacontext;
            DataContext = datacontext;
        }

        public void Show()
        {
            if (window.DataContext is IViewModelWindow viewModelWindow)
                viewModelWindow.OnConfigured(windowFactory);

            window.Show();
        }

        public void ShowDialog()
        {
            if (window.DataContext is IViewModelWindow viewModelWindow)
                viewModelWindow.OnConfigured(windowFactory);

            window.ShowDialog();
        }

        public void Close() => window.Close();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfUI
{
    public class WindowWrapper : IWindow
    {
        private readonly IWindow window;
        private readonly IWindowService windowFactory;

        public object DataContext
        {
            get { return window.DataContext; }
            set { window.DataContext = value; }
        }

        public WindowWrapper(IWindowService windowFactory, IWindow window)
        {
            this.windowFactory = windowFactory;
            this.window = window;
        }

        public WindowWrapper(IWindowService windowFactory, IWindow window, IViewModelWindow datacontext)
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

        public bool? ShowDialog()
        {
            if (window.DataContext is IViewModelWindow viewModelWindow)
                viewModelWindow.OnConfigured(windowFactory);

            return window.ShowDialog();
        }

        public void Close() => window.Close();
    }
}

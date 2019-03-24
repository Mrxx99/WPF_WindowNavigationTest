using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace WpfUI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            IWindowFactory windowFactory = new WindowFactory();

            windowFactory
                .RegisterWindow<MainViewModel, MainWindow>()
                .RegisterWindow<ChildViewModel, ChildWindow>();

            var startWindow = windowFactory.GetWindow(new MainViewModel());
            startWindow.Show();
        }
    }
}

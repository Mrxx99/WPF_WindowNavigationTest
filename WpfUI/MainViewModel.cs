using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfUI
{
    public class MainViewModel : ViewModelBase, IViewModelWindow
    {
        private IWindowService windowFactory;

        public string Title => "This is Title";

        public MainViewModel()
        {

        }

        public ICommand OpenChildViewCommand { get; set; }

        public void OnConfigured(IWindowService windowFactory)
        {
            this.windowFactory = windowFactory;

            OpenChildViewCommand = new DelegateCommand(_ => OpenChildView());
            RaisePropertyChanged(nameof(OpenChildViewCommand));
        }

        private void OpenChildView()
        {
            var childWindow = windowFactory.GetWindow(new ChildViewModel("This is ChildViewModel!"));
            childWindow.Show();
        }
    }
}

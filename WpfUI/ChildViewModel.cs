using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfUI
{
    public class ChildViewModel : ViewModelBase, IViewModelWindow
    {
        private IWindowService windowFactory;

        public string Title { get; set; }

        public ChildViewModel(string title)
        {
            Title = title;
        }

        public void OnConfigured(IWindowService windowFactory)
        {
            this.windowFactory = windowFactory;
        }
    }
}

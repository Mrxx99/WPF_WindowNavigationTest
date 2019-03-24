using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfUI
{
    public interface IViewModelWindow
    {
        void OnConfigured(IWindowService windowFactory);
    }
}

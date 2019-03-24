using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WpfUI
{
    public interface IViewModel
    {
        event PropertyChangedEventHandler PropertyChanged;

        void RaisePropertyChanged([CallerMemberName] string propertyName = "");
    }
}
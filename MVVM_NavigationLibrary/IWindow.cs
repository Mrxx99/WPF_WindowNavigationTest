namespace WpfUI
{
    public interface IWindow
    {
        object DataContext { get; }
        void Close();
        void Show();
        void ShowDialog();
    }
}
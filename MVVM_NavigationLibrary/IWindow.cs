namespace WpfUI
{
    public interface IWindow
    {
        object DataContext { get; set; }
        void Close();
        void Show();
        bool? ShowDialog();
    }
}
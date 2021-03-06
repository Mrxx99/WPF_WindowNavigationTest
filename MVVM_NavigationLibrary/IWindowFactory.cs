﻿
namespace WpfUI
{
    public interface IWindowFactory : IWindowService
    {
        WindowFactory RegisterWindow<TViewModelWindow, TWindow>()
            where TViewModelWindow : IViewModelWindow
            where TWindow : IWindow, new();
    }
}
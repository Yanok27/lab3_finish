using lab3_1_.Locator;
using lab3_1_.Presenters;
using lab3_1_.View;
using System;

namespace lab3_1_
{
    public class Program
    {
        static void Main(string[] args)
        {
            IServiceLocator serviceLocator = new ServiceLocator();
            var menu = serviceLocator.GetService<IMenuView>();
            var presenter = serviceLocator.GetService<IPresenter>();
            presenter.Enable();
            menu.ShowAction();
            menu.GetAction();
        }
    }
}
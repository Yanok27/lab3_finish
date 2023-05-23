using lab3_1_.Presenters;
using lab3_1_.ProductContainer;
using lab3_1_.Searcher;
using lab3_1_.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_1_.Locator
{
    public class ServiceLocator:IServiceLocator
    {
        private readonly Dictionary<object, object> _services;

        public ServiceLocator()
        {
            _services = new Dictionary<object, object>
            {
                {
                    typeof(IProductSearcher), new ProductSearcher(new Shop())
                },
                {
                    typeof(IMenuView), new ConsoleMenu()
                }
            };

            _services.Add(typeof(IPresenter), new Presenter(GetService<IMenuView>(), GetService<IProductSearcher>()));
        }

        public T GetService<T>()
        {
            try
            {
                return (T)_services[typeof(T)];
            }
            catch (KeyNotFoundException)
            {
                throw new ApplicationException("Сервіс не зареєстрованний!");
            }
        }
    }

}

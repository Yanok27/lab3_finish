using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_1_.Locator
{
    public interface IServiceLocator
    {
        T GetService<T>();
    }
}

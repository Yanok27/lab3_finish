using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab3_1_.Products;

namespace lab3_1_.Factories
{
    public interface IProductFactory
    {
        Product CreateProduct(IReadOnlyDictionary<string, string> parameters);
    }
}

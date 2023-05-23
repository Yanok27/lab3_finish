using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab3_1_.Products;

namespace lab3_1_.Readers
{
    public interface IParametersReader
    {
        IEnumerable<IReadOnlyDictionary<string, string>> GetProductsParameters<T>() where T : Product;
    }
}

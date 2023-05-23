using lab3_1_.Factories;
using lab3_1_.Products;
using lab3_1_.Readers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_1_.ProductContainer
{
    public class Shop:IProductContainer
    {
        private readonly Dictionary<IEnumerable<IReadOnlyDictionary<string, string>>, IProductFactory> _productsParameter;
        private readonly List<Product> _products;

        public IEnumerable<Product> Products => _products;

        public Shop()
        {
            _productsParameter = new Dictionary<IEnumerable<IReadOnlyDictionary<string, string>>, IProductFactory>()
            {
                {
                    new ParametersReader().GetProductsParameters<Memory>(), new MemoryFactory()
                },
                {
                   new ParametersReader().GetProductsParameters<HardDrive>(), new HardDriveFactory()
                },
                {
                   new ParametersReader().GetProductsParameters<MotherBoard>(), new MotherBoardFactory()
                },
                {
                    new ParametersReader().GetProductsParameters<Processor>(), new ProcessorFactory()
                }
            };

            _products = new List<Product>();
            InitializeProducts();
        }

        private void InitializeProducts()
        {
            foreach (var (reader, value) in _productsParameter)
            {
                foreach (var dictionary in reader)
                {
                    _products.Add(value.CreateProduct(dictionary));
                }
            }
        }
    }
}


﻿using lab3_1_.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_1_.Searcher
{
    public interface IProductSearcher
    {
        IEnumerable<Product> FindProductByItemNumber(int itemNumber);
        IEnumerable<Product> FindProductByName(string name);
        IEnumerable<Product> FindProductByPrice(int maxPrice);
        IEnumerable<Product> FindProductBySocketType(string socketType);
        IEnumerable<Product> FindProductByChipset(string chipSet);
        IEnumerable<Product> FindProductByMemoryType(string memoryType);
        IEnumerable<Product> FindProductByBusSpeed(int busSpeed);
        IEnumerable<Product> FindProductByCoreCount(int coreCount);
        IEnumerable<Product> FindProductByClockSpeed(double clockSpeed);
        IEnumerable<Product> FindProductByCapacity(int capacity);
        IEnumerable<Product> FindProductByFrequency(int frequency);
        IEnumerable<Product> FindProductByModuleCount(int moduleCount);
        IEnumerable<Product> FindProductBySpeed(int speed);
        IEnumerable<Product> FindProductByInterfaceOfConnect(string interfaceOfConnect);
    }
}

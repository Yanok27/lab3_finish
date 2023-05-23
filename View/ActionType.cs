using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_1_.View
{
    public enum ActionType
    {
        None = -1,
        FindByItemNumber = 1,
        FindByName = 2,
        FindByPrice = 3,
        FindBySocketType = 4,
        FindProductByChipset = 5,
        FindProductByMemoryType = 6,
        FindProductByBusSpeed = 7,
        FindProductByCoreCount = 8,
        FindProductByClockSpeed = 9,
        FindProductByCapacity = 10,
        FindProductByFrequency = 11,
        FindProductByModuleCount = 12,
        FindProductBySpeed = 13,
        FindProductByInterfaceOfConnect = 14
    }
}

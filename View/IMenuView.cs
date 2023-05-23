using lab3_1_.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_1_.View
{
    public interface IMenuView
    {
        void ShowAction();
        void GetAction();
        void ShowResult(IEnumerable<Product> productsResult);

        event Action<ActionType> ActionChoice;
        string GetName();
        int GetItemNumber();
        int GetPrice();
        string GetSocketType();
        string GetChipset();
        string GetMemoryType();
        int GetBusSpeed();
        int GetCoreCount();
        double GetClockSpeed();
        int GetCapacity();
        int GetFrequency();
        int GetModuleCount();
        int GetSpeed();

        string GetInterfaceOfConnect();
    }
}

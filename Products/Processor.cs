using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static lab3_1_.Products.MotherBoard;

namespace lab3_1_.Products
{
    public class Processor:Product, ISocketType
    {
        public string SocketType { get; }
        public int CoreCount { get; }
        public double ClockSpeed { get; }

        public Processor(int itemNumber, string name, double price, string socketType, int coreCount, double clockSpeed) : base(itemNumber, name, price)
        {
            SocketType = socketType;
            CoreCount = coreCount;
            ClockSpeed = clockSpeed;
        }

        public override string GetInformation()
        {
            return $"Processors: " +
                   $"\n\tItem Number: {ItemNumber}" +
                   $"\n\tName: {Name}" +
                   $"\n\tPrice: {Price}" +
                   $"\n\tSocket Type: {SocketType}" +
                   $"\n\tCore Count: {CoreCount}" +
                   $"\n\tClock Speed: {ClockSpeed}";
        }
    }
}

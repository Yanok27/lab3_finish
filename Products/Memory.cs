﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static lab3_1_.Products.HardDrive;
using static lab3_1_.Products.MotherBoard;

namespace lab3_1_.Products
{
    public class Memory:Product, IMemoryType, ICapacity
    {
        public int Capacity { get; }
        public string MemoryType { get; }
        public int Frequency { get; }
        public int ModuleCount { get; }

        public Memory(int itemNumber, string name, double price, int capacity, string memoryType, int frequency, int moduleCount) : base(itemNumber, name, price)
        {
            Capacity = capacity;
            MemoryType = memoryType;
            Frequency = frequency;
            ModuleCount = moduleCount;
        }

        public override string GetInformation()
        {
            return $"Memory: " +
                   $"\n\tItem Number: {ItemNumber}" +
                   $"\n\tName: {Name}" +
                   $"\n\tPrice: {Price}" +
                   $"\n\tCapacity: {Capacity}" +
                   $"\n\tType: {MemoryType}" +
                   $"\n\tFrequency: {Frequency}" +
                   $"\n\tModuleCount: {ModuleCount}";
        }
        
    }
}

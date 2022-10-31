using System;

namespace Patterns.AbstractFactory
{
    public class VictorianCoffeeTable : ICoffeeTable
    {
        public VictorianCoffeeTable()
        {
            Console.WriteLine("Victorian Coffee Table Created!");
        }
        
        public bool HasLegs()
        {
            return true;
        }

        public int GetWidth()
        {
            return 5;
        }

        public int GetHeight()
        {
            return 2;
        }
    }
}
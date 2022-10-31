using System;

namespace Patterns.AbstractFactory
{
    public class VictorianFurnitureFactory : IFurnitureFactory
    {
        public VictorianFurnitureFactory()
        {
            Console.WriteLine("New Victorian Factory Created!");
        }
        
        public IChair CreateChair()
        {
            return new VictorianChair(true,true);
        }

        public ICoffeeTable CreateCoffeeTable()
        {
            return new VictorianCoffeeTable();
        }

        public ICouch CreateCouch()
        {
            return new VictorianCouch();
        }
    }
}
using System;

namespace Patterns.AbstractFactory
{
    public class AbstractFactoryTest
    {
        public static void Main(string[] args)
        {
             Console.WriteLine("Testing Abstract Factory Starting...");
             Console.WriteLine("------------------------------------");
             var victorianFactory = new VictorianFurnitureFactory();
             victorianFactory.CreateChair();
             victorianFactory.CreateCouch();
             victorianFactory.CreateCoffeeTable();
             Console.WriteLine("----------------------------------");
             var modernFurnitureFactory = new ModernFurnitureFactory();
             modernFurnitureFactory.CreateChair();
             modernFurnitureFactory.CreateCouch();
             modernFurnitureFactory.CreateCoffeeTable();
             Console.WriteLine("----------------------------------");
             Console.WriteLine("Testing Abstract Factory Completed");
         }
    }
}
using System;

namespace Patterns.AbstractFactory
{
    public class VictorianCouch : ICouch
    {
        public VictorianCouch()
        {
            Console.WriteLine("Victorian Couch Created!");
        }
        
        public int NumberOfSeats()
        {
            return 3;
        }

        public int GetLength()
        {
            return 8;
        }

        public int GetHeight()
        {
            return 4;
        }
    }
}
namespace Patterns.AbstractFactory
{
    public class ModernCouch : ICouch
    {
        public ModernCouch()
        {
            Console.WriteLine("Modern Couch Created!");
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
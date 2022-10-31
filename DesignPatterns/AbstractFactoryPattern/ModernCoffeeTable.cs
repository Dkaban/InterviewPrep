namespace Patterns.AbstractFactory
{
    public class ModernCoffeeTable : ICoffeeTable
    {
        public ModernCoffeeTable()
        {
            Console.WriteLine("Modern Coffee Table Created!");
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
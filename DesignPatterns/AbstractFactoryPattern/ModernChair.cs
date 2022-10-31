namespace Patterns.AbstractFactory
{
    public class ModernChair : IChair
    {
        public ModernChair()
        {
            Console.WriteLine("Modern Chair Created!");
        }

        public bool HasLegs()
        {
            return true;
        }

        public bool CanSitOn()
        {
            return true;
        }
    }
}
namespace Patterns.AbstractFactory
{
    public class ModernFurnitureFactory : IFurnitureFactory
    {
        public IChair CreateChair()
        {
            return new ModernChair();
        }

        public ICoffeeTable CreateCoffeeTable()
        {
            return new ModernCoffeeTable();
        }

        public ICouch CreateCouch()
        {
            return new ModernCouch();
        }
    }
}
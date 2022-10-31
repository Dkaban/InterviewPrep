namespace Patterns.AbstractFactory
{
    public interface IFurnitureFactory
    {
        IChair CreateChair();
        ICoffeeTable CreateCoffeeTable();
        ICouch CreateCouch();
    }
}

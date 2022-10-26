namespace DesignPatterns.DecoratorPattern
{
    public class PlainPizza : Pizza
    {
        public string GetDescription()
        {
            return "Thin Dough";
        }

        public double GetCost()
        {
            return 4.00;
        }
}
}

namespace DesignPatterns.DecoratorPattern
{
    class Mozzarella : ToppingDecorator
    {
        public Mozzarella(Pizza newPizza) : base(newPizza)
        {
            Console.WriteLine("Adding Dough");
            Console.WriteLine("Adding Moz");
        }
        
        public override string GetDescription()
        {
            Console.WriteLine("Temp Description : " + tempPizza.GetDescription());
            return tempPizza.GetDescription() + ", Mozzarella"; 
        }

        public override double GetCost()
        {
            return tempPizza.GetCost() + .50;
        }
    }
}
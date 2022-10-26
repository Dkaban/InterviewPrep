namespace DesignPatterns.DecoratorPattern
    {class TomatoSauce : ToppingDecorator
    {
        public TomatoSauce(Pizza newPizza) : base(newPizza)
        {
            Console.WriteLine("Adding Sauce");
        }
        
        public override string GetDescription()
        {
            return tempPizza.GetDescription() + ", Tomato Sauce";
        }

        public override double GetCost()
        {
            return tempPizza.GetCost() + 1.50;
        }
    }
}
namespace DesignPatterns.DecoratorPattern
{
    abstract class ToppingDecorator : Pizza
    {
        protected Pizza tempPizza;

        public ToppingDecorator(Pizza newPizza)
        {
            tempPizza = newPizza;
        }

        public virtual string GetDescription()
        {
            return tempPizza.GetDescription();
        }

        public virtual double GetCost()
        {
            return tempPizza.GetCost();
        }
    }
}

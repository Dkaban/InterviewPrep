namespace DesignPatterns.DecoratorPattern
{
        public class PizzaMaker
        { 
                public static void Main(string[] args)
                {
                        Pizza basicPizza = new TomatoSauce(new Mozzarella(new PlainPizza()));
                        Console.WriteLine("Ingredients : " + basicPizza.GetDescription());
                        Console.WriteLine("Total Cost : " + basicPizza.GetCost());
                }
        }
}
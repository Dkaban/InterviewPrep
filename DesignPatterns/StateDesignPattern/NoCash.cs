namespace DesignPatterns.StateDesignPattern
{
    public class NoCash : ATMState
    {
        private ATMMachine _atmMachine;
        
        public NoCash(ATMMachine newATMMachine)
        {
            _atmMachine = newATMMachine;
        }
        
        public void InsertCard()
        {
            Console.WriteLine("We don't have money");
        }

        public void EjectCard()
        {
            Console.WriteLine("We don't have money you didn't enter a card");
        }

        public void InsertPin(int pinEntered)
        {
            Console.WriteLine("We don't have money");
        }

        public void RequestCash(int cashToWithdraw)
        {
            Console.WriteLine("We don't have any money");
        }
    }
}

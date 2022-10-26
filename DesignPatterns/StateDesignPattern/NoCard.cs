namespace DesignPatterns.StateDesignPattern
{
    public class NoCard : ATMState
    {
        private ATMMachine _atmMachine;
        
        public NoCard(ATMMachine newATMMachine)
        {
            _atmMachine = newATMMachine;
        }
        
        public void InsertCard()
        {
            Console.WriteLine("Please enter a PIN");
            _atmMachine.SetAtmState(_atmMachine.GetYesCardState());
        }

        public void EjectCard()
        {
            Console.WriteLine("Enter a card first");
        }

        public void InsertPin(int pinEntered)
        {
            Console.WriteLine("Enter a card first");
        }

        public void RequestCash(int cashToWithdraw)
        {
            Console.WriteLine("Enter a card first");
        }
    }
}

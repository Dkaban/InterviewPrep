namespace DesignPatterns.StateDesignPattern
{
    public class HasCard : ATMState
    {
        private ATMMachine _atmMachine;

        public HasCard(ATMMachine newATMMachine)
        {
            _atmMachine = newATMMachine;
        }
        
        public void InsertCard()
        {
            Console.WriteLine("You can't enter more than one card");
        }

        public void EjectCard()
        {
            Console.WriteLine("Card Ejected");
            _atmMachine.SetAtmState(_atmMachine.GetNoCardState());
        }

        public void InsertPin(int pinEntered)
        {
            if (pinEntered == 1234)
            {
                Console.WriteLine("Correct Pin");
                _atmMachine.CorrectPinEntered = true;
                _atmMachine.SetAtmState(_atmMachine.GetHasPin());
            }
            else
            {
                _atmMachine.CorrectPinEntered = false;
                Console.WriteLine("Incorrect Pin");
                Console.WriteLine("Card Ejected");
                _atmMachine.SetAtmState(_atmMachine.GetNoCardState());
            }
        }

        public void RequestCash(int cashToWithdraw)
        {
            Console.WriteLine("Enter PIN first");
        }
    }
}

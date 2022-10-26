namespace DesignPatterns.StateDesignPattern
{
    public class HasPin : ATMState
    {
        private ATMMachine _atmMachine;
        
        public HasPin(ATMMachine newATMMachine)
        {
            _atmMachine = newATMMachine;
        }
        
        public void InsertCard()
        {
            Console.WriteLine("You can't insert another card");
        }

        public void EjectCard()
        {
            Console.WriteLine("Card Ejected");
            _atmMachine.SetAtmState(_atmMachine.GetNoCardState());
        }

        public void InsertPin(int pinEntered)
        {
            Console.WriteLine("Already entered PIN");
        }

        public void RequestCash(int cashToWithdraw)
        {
            if (cashToWithdraw > _atmMachine.CashInMachine)
            {
                Console.WriteLine("Asked for too much cash");
                _atmMachine.EjectCard();
                _atmMachine.SetAtmState(_atmMachine.GetNoCardState());
            }
            else
            {
                Console.WriteLine(cashToWithdraw + " is provided by the machine");
                _atmMachine.SetCashInMachine(_atmMachine.CashInMachine - cashToWithdraw);
                
                Console.WriteLine("Card Ejected");
                _atmMachine.SetAtmState(_atmMachine.GetNoCardState());

                if (_atmMachine.CashInMachine <= 0)
                {
                    _atmMachine.SetAtmState(_atmMachine.GetNoCashState());
                }
            }
        }
    }
}

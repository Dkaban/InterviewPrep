namespace DesignPatterns.StateDesignPattern
{
    public class ATMMachine
    {
        ATMState hasCard;
        ATMState noCard;
        ATMState hasCorrectPin;
        ATMState atmOutOfMoney;

        ATMState atmState;
        public int CashInMachine = 2000;
        public bool CorrectPinEntered = false;

        public ATMMachine()
        {
            hasCard = new HasCard(this);
            noCard = new NoCard(this);
            hasCorrectPin = new HasPin(this);
            atmOutOfMoney = new NoCash(this);
            atmState = noCard;

            if (CashInMachine < 0)
            {
                atmState = atmOutOfMoney;
            }
        }

        public void SetAtmState(ATMState newATMState)
        {
            atmState = newATMState;
        }

        public void SetCashInMachine(int newCashInMachine)
        {
            CashInMachine = newCashInMachine;
        }

        public void InsertCard()
        {
            atmState.InsertCard();
        }

        public void EjectCard()
        {
            atmState.EjectCard();
        }

        public void InsertPin(int pinEntered)
        {
            atmState.InsertPin(pinEntered);
        }

        public void RequestCash(int cashToWithdraw)
        {
            atmState.RequestCash(cashToWithdraw);
        }

        public ATMState GetYesCardState()
        {
            return hasCard;
        }

        public ATMState GetNoCardState()
        {
            return noCard;
        }

        public ATMState GetHasPin()
        {
            return hasCorrectPin;
        }

        public ATMState GetNoCashState()
        {
            return atmOutOfMoney;
        }
    }
}

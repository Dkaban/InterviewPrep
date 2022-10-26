namespace DesignPatterns.StateDesignPattern
{
    public interface ATMState
    {
        public void InsertCard();
        public void EjectCard();
        public void InsertPin(int pinEntered);
        public void RequestCash(int cashToWithdraw);
    }
}

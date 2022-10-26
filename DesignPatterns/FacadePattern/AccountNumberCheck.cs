namespace DesignPatterns.FacadePattern
{
    public class AccountNumberCheck
    {
        private int accountNumber = 12345678;

        public int GetAccountNumber()
        {
            return accountNumber;
        }

        public bool AccountActive(int accountNumToCheck)
        {
            return accountNumToCheck == GetAccountNumber();
        }
    }
}

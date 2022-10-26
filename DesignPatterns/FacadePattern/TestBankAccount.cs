namespace DesignPatterns.FacadePattern
{
    public class TestBankAccount
    {
        public static void Main(string[] args)
        {
            var accessingBank = new BankAccountFacade(12345678, 1234);
            accessingBank.WithdrawCash(50);
            accessingBank.WithdrawCash(900);
            accessingBank.DepositCash(200);
        }
    }
}

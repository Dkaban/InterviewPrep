namespace DesignPatterns.FacadePattern
{
    public class BankAccountFacade
    {
        private int accountNumber;
        private int securityCode;

        private AccountNumberCheck accountChecker;
        private SecurityCodeCheck codeChecker;
        private FundsCheck fundChecker;
        private WelcomeToBank bankWelcome;

        public BankAccountFacade(int newAcctNum, int newSecCode)
        {
            accountNumber = newAcctNum;
            securityCode = newSecCode;
            bankWelcome = new WelcomeToBank();
            accountChecker = new AccountNumberCheck();
            codeChecker = new SecurityCodeCheck();
            fundChecker = new FundsCheck();
        }

        public int GetAccountNumber()
        {
            return accountNumber;
        }

        public int GetSecurityCode()
        {
            return securityCode;
        }

        public void WithdrawCash(double cashToGet)
        {
            if (accountChecker.AccountActive(GetAccountNumber()) && codeChecker.IsCodeCorrect(GetSecurityCode())
                                                                 && fundChecker.HaveEnoughMoney(cashToGet))
            {
                Console.WriteLine("Transaction Complete.");
            }
            else
            {
                Console.WriteLine("Transaction Failed");
            }
        }

        public void DepositCash(double cashToDeposit)
        {
            if (accountChecker.AccountActive(GetAccountNumber()) && codeChecker.IsCodeCorrect(GetSecurityCode()))
            {
                fundChecker.MakeDeposit(cashToDeposit);
                Console.WriteLine("Transaction Complete.");
            }
            else
            {
                Console.WriteLine("Transaction Failed");
            }
        }
    }
}

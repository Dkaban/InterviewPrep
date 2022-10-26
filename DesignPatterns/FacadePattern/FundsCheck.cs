namespace DesignPatterns.FacadePattern
{
    public class FundsCheck
    {
        private double _cashInAccount = 1000;

        public double GetCashInAccount()
        {
            return _cashInAccount;
        }

        public void DecreaseCashInAccount(double cashWithdrawn)
        {
            _cashInAccount -= cashWithdrawn;
        }

        public void IncreaseCashInAccount(double cashDeposited)
        {
            _cashInAccount += cashDeposited;
        }

        public bool HaveEnoughMoney(double cashToWithdrawal)
        {
            if (cashToWithdrawal > GetCashInAccount())
            {
                Console.WriteLine("You don't have enough money");
                Console.WriteLine("Current Balance: " + GetCashInAccount());
                return false;
            }
            else
            {
                DecreaseCashInAccount(cashToWithdrawal);
                Console.WriteLine("Withdrawal Complete");
                Console.WriteLine("Current Balance: " + GetCashInAccount());
                return true;
            }
        }

        public void MakeDeposit(double cashToDeposit)
        {
            IncreaseCashInAccount(cashToDeposit);
            Console.WriteLine("Deposit Complete.  Cash Balance: " + GetCashInAccount());
        }
    }
}

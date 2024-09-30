namespace Task_4_
{
    public class CheckingAccount : Account
    {
        private const double WithdrawalFee = 1.50;

        public CheckingAccount(string name = "Account", double balance = 0.0)
            : base(name, balance)
        {

        }

        public bool Withdraw(double amount)
        {
            double totalAmount = amount + WithdrawalFee;
            if (GetBalance() - totalAmount >= 0)
            {
                return base.Withdraw(totalAmount);
            }
            else
            {
                return false;
            }
        }
    }
}

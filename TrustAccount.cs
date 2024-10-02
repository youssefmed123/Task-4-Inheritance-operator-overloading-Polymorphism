namespace Task_4_
{
    public class TrustAccount : Account
    {
       private double interestRate;
       private int withdrawalCount;
       private const int MaxWithdrawalsPerYear = 3;
       private const double MaxWithdrawalPercentage = 0.20;
       private const double BonusThreshold = 5000.00;
       private const double BonusAmount = 50.00;

        public TrustAccount(string name = "Account", double balance = 0.0, double interestRate = 0.02)
            : base(name, balance)
        {
            this.interestRate = interestRate;
            this.withdrawalCount = 0;
        }

        public bool Deposit(double amount)
        {
            bool success = base.Deposit(amount);
            if (success && amount >= BonusThreshold)
            {
                base.Deposit(BonusAmount);
            }
            return success;
        }

        public bool Withdraw(double amount)
        {
            if (withdrawalCount < MaxWithdrawalsPerYear && amount <= GetBalance() * MaxWithdrawalPercentage)
            {
                withdrawalCount++;
                return base.Withdraw(amount);
            }
            return false;
        }

        public void ApplyInterest()
        {
            double interest = GetBalance() * interestRate;
            Deposit(interest);
        }

        public void ResetWithdrawalCount()
        {
            withdrawalCount = 0;
        }

        public double GetInterestRate()
        {
            return interestRate;
        }

        public void SetInterestRate(double newRate)
        {
            if (newRate >= 0)
            {
                interestRate = newRate;
            }
        }
    }
}

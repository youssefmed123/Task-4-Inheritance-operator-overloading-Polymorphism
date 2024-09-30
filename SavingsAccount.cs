namespace Task_4_
{
    public class SavingsAccount : Account
    {
        private double interestRate;

        public SavingsAccount(string name = "Account", double balance = 0.0, double interestRate = 0.02)
            : base(name, balance)
        {
            this.interestRate = interestRate;
        }

        public void ApplyInterest()
        {
            double interest = GetBalance() * interestRate;
            Deposit(interest);
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

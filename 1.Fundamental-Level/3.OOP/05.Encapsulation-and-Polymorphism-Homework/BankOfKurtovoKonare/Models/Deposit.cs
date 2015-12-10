namespace BankOfKurtovoKonare.Models
{
    public class Deposit : Account
    {
        public Deposit(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {
        }

        public override void DepositMoney(decimal money)
        {
            this.Balance += money;
        }

        public void WithdrawMoney(decimal money)
        {
            this.Balance -= money;
        }

        public override decimal CalculateInterest(int months)
        {
            if (this.Balance <= 1000)
            {
                return 0;
            }

            return this.Balance * (1 + this.InterestRate * months);
        }
    }
}

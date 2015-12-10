namespace BankOfKurtovoKonare.Models
{
    public class Loan : Account
    {
        public Loan(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {
        }

        public override void DepositMoney(decimal money)
        {
            this.Balance -= money;
        }

        public override decimal CalculateInterest(int months)
        {
            if (months <= 3 && this.Customer == Customer.Individuals)
            {
                return 0;
            }

            if (months <= 2 && this.Customer == Customer.Companies)
            {
                return 0;
            }

            return this.Balance * (1 + this.InterestRate * months);
        }
    }
}

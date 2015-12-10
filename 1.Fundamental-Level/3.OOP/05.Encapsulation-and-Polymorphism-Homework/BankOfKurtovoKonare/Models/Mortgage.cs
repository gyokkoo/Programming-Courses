namespace BankOfKurtovoKonare.Models
{
    public class Mortgage : Account
    {
        public Mortgage(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {
        }

        public override void DepositMoney(decimal money)
        {
            this.Balance -= money;
        }

        public override decimal CalculateInterest(int months)
        {
            if (months <= 6 && this.Customer == Customer.Individuals)
            {
                return 0;
            }

            if (months <= 12 && this.Customer == Customer.Companies)
            {
                return (this.Balance * (1 + this.InterestRate * months)) / 2;
            }

            return this.Balance * (1 + this.InterestRate * months);
        }
    }
}

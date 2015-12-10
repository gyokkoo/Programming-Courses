using System.Text;
using BankOfKurtovoKonare.Interfaces;

namespace BankOfKurtovoKonare.Models
{
    public abstract class Account : IAccount
    {
        protected Account(Customer customer, decimal balance, decimal interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public Customer Customer { get; set; }

        public decimal Balance { get; set; }

        public decimal InterestRate { get; set; }

        public abstract void DepositMoney(decimal money);

        public abstract decimal CalculateInterest(int months);

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine("Type -> " + this.GetType().Name);
            result.AppendLine("Customer -> " + this.Customer);
            result.AppendLine("Balance = " + this.Balance);
            result.AppendLine("Interest rate = " + this.InterestRate*100 + " %");

            return result.ToString();

        }
    }
}

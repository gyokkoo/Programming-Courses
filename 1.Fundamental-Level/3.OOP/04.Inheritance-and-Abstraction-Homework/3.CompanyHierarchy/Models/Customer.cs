using _3.CompanyHierarchy.Interfaces;
using System;

namespace _3.CompanyHierarchy
{
    public class Customer : Person, ICustomer
    {
        private decimal balance;

        public Customer(uint id, string firstName, string lastName, decimal balance)
            : base(id, firstName, lastName)
        {
            this.Balance = balance;
        }

        public decimal Balance
        {
            get
            {
                return this.balance;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Balance must be a positive number");
                }

                this.balance = value;
            }
        }

        public override string ToString()
        {
            return String.Format("ID {0} -> {1} {2} {3} has balance {4}",
                this.Id, this.GetType().Name, this.FirstName, this.LastName, this.Balance);
        }
    }
}

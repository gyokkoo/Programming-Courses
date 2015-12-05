using _3.CompanyHierarchy.Interfaces;
using System;

namespace _3.CompanyHierarchy
{
    public abstract class Employee : Person, IEmployee
    {
        private decimal salary;

        public Employee(uint id, string firstName, string lastName, decimal salary, DepartmentType department)
            : base(id, firstName, lastName)
        {
            this.Salary = salary;
            this.Department = department;
        }

        public DepartmentType Department { get; set; }

        public decimal Salary
        {
            get
            {
                return this.salary;
            }

            set
            {
                if (value < 400)
                {
                    throw new ArgumentOutOfRangeException("The salary must be at least 400");
                }

                this.salary = value;
            }
        }
    }
}

using System;
using System.Collections.Generic;

namespace _3.CompanyHierarchy
{
    class SalesEmployee : RegularEmployee
    {
        private List<Sale> sales;

        public SalesEmployee(uint id, string firstName, string lastName, decimal salary, DepartmentType department) 
            : base(id, firstName, lastName, salary, department)
        {
            this.sales = new List<Sale>();
        }

        //TODO: Change to IEnumarble
        public List<Sale> Sales
        {
            get { return this.sales; }
        }

        //Add

        public override string ToString()
        {
            return String.Format("ID {0} -> {1} {2} {3} from {4} has salary {5}",
                this.Id, this.GetType().Name, this.FirstName, this.LastName, this.Department, this.Salary);
        }
    }
}

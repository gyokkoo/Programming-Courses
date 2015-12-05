using System;

namespace _3.CompanyHierarchy
{
    class RegularEmployee : Employee
    {
        public RegularEmployee(uint id, string firstName, string lastName, decimal salary, DepartmentType department) 
            : base(id, firstName, lastName, salary, department)
        {
        }

        public override string ToString()
        {
            return String.Format("ID {0} -> {1} {2} {3} has salary {4}", 
                this.Id, this.GetType().Name, this.FirstName, this.LastName, this.Salary);
        }
    }
}

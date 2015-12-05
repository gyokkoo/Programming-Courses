using _3.CompanyHierarchy.Interfaces;
using System;
using System.Collections.Generic;

namespace _3.CompanyHierarchy
{
    public class Manager : Employee, IManager
    {
        private List<Employee> employees;

        public Manager(uint id, string firstName, string lastName, decimal salary, DepartmentType department) 
            : base(id, firstName, lastName, salary, department)
        {
            this.employees = new List<Employee>();
        }

        public IEnumerable<Employee> Employees
        {
            get
            {
                return this.employees;
            }
        }

        public void AddEmployee(Employee employee)
        {
            if(employee == null)
            {
                throw new ArgumentNullException("Employee cannot be null");
            }

            if(employee.Department != this.Department)
            {
                throw new ArgumentException("Employee and manager must be the same");
            }

            this.employees.Add(employee);
        }

        public override string ToString()
        {
            return String.Format("ID {0} -> {1} {2} {3} has salary {4}", 
                this.Id, this.GetType().Name, this.FirstName, this.LastName, this.Salary);
        }
    }
}

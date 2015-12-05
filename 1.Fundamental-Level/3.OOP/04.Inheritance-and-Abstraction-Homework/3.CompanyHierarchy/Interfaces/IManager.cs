using System;
using System.Collections.Generic;

namespace _3.CompanyHierarchy.Interfaces
{
    public interface IManager
    {
        IEnumerable<Employee> Employees { get; }
        void AddEmployee(Employee employee);
    }
}

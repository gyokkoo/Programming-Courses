using System;
using System.Collections.Generic;

namespace _3.CompanyHierarchy
{
    class CompanyHierarchy
    {
        static void Main()
        {
            Console.Title = "Problem 3.	Company Hierarchy";

            List<Person> people = new List<Person>()
            {
                new Manager(1550, "Ivan", "Ivanov", 1500, DepartmentType.Marketing),
                new RegularEmployee(1123, "Iliqn", "Kolev", 800, DepartmentType.Production),
                new Customer(1010, "Veselnika", "Stoeva", 500),
                new Developer(3322, "Stavri", "Ivanov", 2500, DepartmentType.Production),
                new SalesEmployee(6543, "Sasho", "Ivanov", 1500, DepartmentType.Marketing)
            };

            foreach (var person in people)
            {
                Console.WriteLine(person.ToString());
            }
        }
    }
}

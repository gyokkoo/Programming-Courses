using System;

namespace _3.CompanyHierarchy.Interfaces
{
    interface ICustomer : IPerson
    {
        decimal Balance { get; set; }
    }
}

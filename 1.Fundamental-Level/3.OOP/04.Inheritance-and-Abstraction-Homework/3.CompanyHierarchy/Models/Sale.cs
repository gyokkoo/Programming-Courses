using System;

namespace _3.CompanyHierarchy
{
    class Sale
    {
        public Sale(string productName, DateTime soldOn, decimal price)
        {
            this.ProductName = productName;
            this.SoldOn = soldOn;
            this.Price = price;
        }

        public string ProductName { get; set; }

        public DateTime SoldOn { get; set; }

        public decimal Price { get; set; }
    }
}

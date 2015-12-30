namespace Orders
{
    using System;
    using System.Globalization;
    using System.Linq;
    using System.Threading;

    public class OrdersProgram
    {
        public static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            DataMapper dataMapper = new DataMapper();
            var categories = dataMapper.GetAllCategories();
            var products = dataMapper.GetAllProducts();
            var orders = dataMapper.GetAllOrders();

            // Names of the 5 most expensive products
            var productNames = products
                .OrderByDescending(p => p.UnitPrice)
                .Take(5)
                .Select(p => p.Name);
            Console.WriteLine(string.Join(Environment.NewLine, productNames));

            Console.WriteLine(new string('-', 10));

            // Number of products in each category
            var numberOfProducts = products
                .GroupBy(p => p.CategoryId)
                .Select(group => new { Category = categories.First(c => c.Id == group.Key).Name, Count = group.Count() })
                .ToList();
            foreach (var item in numberOfProducts)
            {
                Console.WriteLine("{0}: {1}", item.Category, item.Count);
            }

            Console.WriteLine(new string('-', 10));

            // The 5 top products (by order quantity)
            var topProducts = orders
                .GroupBy(o => o.ProductId)
                .Select(group => new { Product = products.First(p => p.Id == group.Key).Name, Quantities = group.Sum(innerGroup => innerGroup.Quantity) })
                .OrderByDescending(q => q.Quantities)
                .Take(5);
            foreach (var item in topProducts)
            {
                Console.WriteLine("{0}: {1}", item.Product, item.Quantities);
            }

            Console.WriteLine(new string('-', 10));

            // The most profitable category
            var category = orders
                .GroupBy(o => o.ProductId)
                .Select(g => new { catId = products.First(p => p.Id == g.Key).CategoryId, price = products.First(p => p.Id == g.Key).UnitPrice, quantity = g.Sum(p => p.Quantity) })
                .GroupBy(gg => gg.catId)
                .Select(group => new { categoryName = categories.First(c => c.Id == group.Key).Name, totalQuantity = group.Sum(g => g.quantity * g.price) })
                .OrderByDescending(g => g.totalQuantity)
                .First();
            Console.WriteLine("{0}: {1}", category.categoryName, category.totalQuantity);
        }
    }
}

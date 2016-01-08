namespace Orders
{
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using Models;

    public class DataMapper
    {
        private const string DefaultCategoriesFilePath = "../../Data/categories.txt";
        private const string DefaultProductsFilePath = "../../Data/products.txt";
        private const string DefaultOrdersFilePath = "../../Data/orders.txt";

        private readonly string categoriesFileName;
        private readonly string productsFileName;
        private readonly string ordersFileName;

        public DataMapper(string categoriesFileName, string productsFileName, string ordersFileName)
        {
            this.categoriesFileName = categoriesFileName;
            this.productsFileName = productsFileName;
            this.ordersFileName = ordersFileName;
        }

        public DataMapper()
            : this(DefaultCategoriesFilePath, DefaultProductsFilePath, DefaultOrdersFilePath)
        {
        }

        public IEnumerable<Category> GetAllCategories()
        {
            var categories = ReadFileLines(this.categoriesFileName, true);

            return categories
                .Select(line => line.Split(','))
                .Select(lineParams => new Category
                {
                    Id = int.Parse(lineParams[0]),
                    Name = lineParams[1],
                    Description = lineParams[2]
                });
        }

        public IEnumerable<Product> GetAllProducts()
        {
            var products = ReadFileLines(this.productsFileName, true);

            return products
                .Select(line => line.Split(','))
                .Select(lineParams => new Product
                {
                    Id = int.Parse(lineParams[0]),
                    Name = lineParams[1],
                    CategoryId = int.Parse(lineParams[2]),
                    UnitPrice = decimal.Parse(lineParams[3]),
                    UnitsInStock = int.Parse(lineParams[4]),
                });
        }

        public IEnumerable<Order> GetAllOrders()
        {
            var orders = ReadFileLines(this.ordersFileName, true);

            return orders
                .Select(line => line.Split(','))
                .Select(lineParams => new Order
                {
                    OrderId = int.Parse(lineParams[0]),
                    ProductId = int.Parse(lineParams[1]),
                    Quantity = int.Parse(lineParams[2]),
                    Discount = decimal.Parse(lineParams[3]),
                });
        }

        private static IEnumerable<string> ReadFileLines(string fileName, bool hasHeader)
        {
            var allLines = new List<string>();
            using (var reader = new StreamReader(fileName))
            {
                string currentLine;
                if (hasHeader)
                {
                    reader.ReadLine();
                }

                while ((currentLine = reader.ReadLine()) != null)
                {
                    allLines.Add(currentLine);
                }
            }

            return allLines;
        }
    }
}

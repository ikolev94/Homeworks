using System.Collections.Generic;
using System.Linq;
using System.IO;
using Orders.Models;

namespace Orders
{
    public class DataMapper
    {
        private readonly string categoriesFileName;
        private readonly string productsFileName;
        private readonly string ordersFileName;

        public DataMapper(string categoriesFileNameInput, string productsFileNameInput, string ordersFileNameInput)
        {
            this.categoriesFileName = categoriesFileNameInput;
            this.productsFileName = productsFileNameInput;
            this.ordersFileName = ordersFileNameInput;
        }

        public DataMapper()
            : this("../../Data/categories.txt", "../../Data/products.txt", "../../Data/orders.txt")
        {
        }

        public IEnumerable<Category> GetAllCategories()
        {
            var categorysFromFile = readFileLines(this.categoriesFileName, true);
            return categorysFromFile
                .Select(category => category.Split(','))
                .Select(categoryArgs => new Category
                {
                    Id = int.Parse(categoryArgs[0]),
                    Name = categoryArgs[1],
                    Description = categoryArgs[2]
                });
        }
        
        public IEnumerable<Product> GetAllProducts()
        {
            var products = readFileLines(this.productsFileName, true);
            return products
                .Select(productInput => productInput.Split(','))
                .Select(productArgs => new Product
                {
                    Id = int.Parse(productArgs[0]),
                    Name = productArgs[1],
                    CategoryId = int.Parse(productArgs[2]),
                    UnitPrice = decimal.Parse(productArgs[3]),
                    UnitsInStock = int.Parse(productArgs[4]),
                });
        }

        public IEnumerable<Order> GetAllOrders()
        {
            var orders = readFileLines(this.ordersFileName, true);
            return orders
                .Select(productInput => productInput.Split(','))
                .Select(productArgs => new Order
                {
                    Id = int.Parse(productArgs[0]),
                    ProductId = int.Parse(productArgs[1]),
                    Quant = int.Parse(productArgs[2]),
                    Discount = decimal.Parse(productArgs[3]),
                });
        }

        private List<string> readFileLines(string filename, bool hasHeader)
        {
            var allLines = new List<string>();
            using (var reader = new StreamReader(filename))
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

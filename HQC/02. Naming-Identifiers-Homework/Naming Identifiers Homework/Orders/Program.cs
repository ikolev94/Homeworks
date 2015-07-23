using System;
using System.Globalization;
using System.Linq;
using System.Threading;

namespace Orders
{
    class Program
    {
        private const int NumberOfDashes = 10;
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            var dataMapper = new DataMapper();
            var allCategories = dataMapper.GetAllCategories();
            var allProducts = dataMapper.GetAllProducts();
            var allOrders = dataMapper.GetAllOrders();

            // Names of the 5 most expensive products
            var first = allProducts
                .OrderByDescending(product => product.UnitPrice)
                .Take(5)
                .Select(product => product.Name);
            Console.WriteLine(string.Join(Environment.NewLine, first));

            Console.WriteLine(new string('-', NumberOfDashes));

            // Number of products in each category
            var second = allProducts
                .GroupBy(product => product.CategoryId)
                .Select(products => new { Category = allCategories.First(category => category.Id == products.Key).Name
                    , Count = products.Count() })
                .ToList();

            foreach (var item in second)
            {
                Console.WriteLine("{0}: {1}", item.Category, item.Count);
            }

            Console.WriteLine(new string('-', NumberOfDashes));

            // The 5 top products (by order quantity)
            var third = allOrders
                .GroupBy(order => order.ProductId)
                .Select(orders => new { Product = allProducts.First(product => product.Id == orders.Key).Name
                    , Quantities = orders.Sum(order => order.Quant) })
                .OrderByDescending(q => q.Quantities)
                .Take(5);

            foreach (var item in third)
            {
                Console.WriteLine("{0}: {1}", item.Product, item.Quantities);
            }

            Console.WriteLine(new string('-', NumberOfDashes));

            // The most profitable category
            var mostProfitableCategory = allOrders
                .GroupBy(order => order.ProductId)
                .Select(grouping => new { catId = allProducts.First(product => product.Id == grouping.Key).CategoryId
                    , price = allProducts.First(product => product.Id == grouping.Key).UnitPrice
                    , quantity = grouping.Sum(order => order.Quant) })
                .GroupBy(gg => gg.catId)
                .Select(group => new { CategoryName = allCategories.First(category => category.Id == group.Key).Name
                    , TotalQuantity = group.Sum(g => g.quantity * g.price) })
                .OrderByDescending(g => g.TotalQuantity)
                .First();
            Console.WriteLine("{0}: {1}", mostProfitableCategory.CategoryName, mostProfitableCategory.TotalQuantity);
        }
    }
}

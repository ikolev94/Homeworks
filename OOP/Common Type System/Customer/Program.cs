using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer("Mariq", "Gogova","Totova", "11121314",
                "Sofia 34", "12321", "mgogo@abv.bg", new List<Payment>() { new Payment("abv", 11212) },CustomerType.Golden);

            var copy = (Customer)customer.Clone();

            Console.WriteLine(customer == copy);
            Console.WriteLine(customer);
            copy.LastName = "Changes!";
            
            Console.WriteLine(customer);
            Console.WriteLine(copy);
        }
    }
}

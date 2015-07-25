using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace Customer
{
    class Payment
    {
        public Payment(string name,decimal price)
        {
            this.ProductName = name;
            this.Price = price;
        }
        private string ProductName { set; get; }
        private decimal Price { set; get; }
    }
}

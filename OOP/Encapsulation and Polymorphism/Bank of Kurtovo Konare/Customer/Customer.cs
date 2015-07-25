using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank_of_Kurtovo_Konare.Interfaces;

namespace Bank_of_Kurtovo_Konare.Customer
{
    class Customer:ICustomer
    {
        private string name;


        public Customer(string name)
        {
            this.Name = name;
        }
        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Customer name cannot be null");
                }
                else
                {
                    this.name = value;
                }
            }
        }
    }
}

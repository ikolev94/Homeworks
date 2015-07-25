using System;
using System.Net;


namespace PC_Catalog
{
    class Component
    {
        private string name;
        private decimal price;

        public Component(string name,decimal price)
        {
            this.Name = name;
            this.Price = price;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException();
                }
                this.name = value;
            }
        }
        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (value<0)
                {
                    throw new ArgumentException();
                }
                this.price = value;
            }
        }
    }
}

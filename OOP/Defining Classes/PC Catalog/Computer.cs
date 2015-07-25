using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_Catalog
{
    class Computer
    {
        private List<Component> component;
        private string name;
        private decimal price;

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
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                decimal sum = this.Component.Sum(component => component.Price);
                this.price = sum;
            }
        }
        public List<Component> Component
        {
            get { return this.component; }
            set { this.component = value; }
        }
        public Computer(string name, List<Component> components)
        {
            this.Name = name;
            this.Component = components;
            this.Price = components.Sum(component => component.Price);
        }

        public Computer(string name):this(name,new List<Component>())
        {

        }
        public void GetComponents()
        {
            Console.Write("Components: ");
            if (component.Count == 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                Console.WriteLine();
                foreach (var comonent in this.Component)
                {
                    Console.WriteLine("{0} witch costs: {1} BGN", comonent.Name, comonent.Price);
                }
            }
        }

        public void GetPrice()
        {
            Console.WriteLine("Total price is: {0:f}", this.price);
        }

        public void GetName()
        {
            Console.WriteLine("Computers name is: {0}", this.name);
        }

        public override string ToString()
        {
            return string.Format("Computer name: {0}\nprice: {1}", this.name, this.price);
        }
        
    }
}

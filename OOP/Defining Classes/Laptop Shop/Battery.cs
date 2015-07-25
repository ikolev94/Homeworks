using System;


namespace Laptop_Shop
{
    class Battery
    {
        private string name;
        private double life;

        public Battery(string name, double life)
        {
            this.Name = name;
            this.Life = life;
        }

        public Battery(string name) : this(name, 0.0) { }

        public Battery() : this("", 0.0) { }
        public double Life
        {
            get { return this.life; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Battery Life cannot be negative");
                }
                this.life = value;
            }
        }
        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Battery cannot be negative");
                }
                this.name = value;
            }
        }
    }
}

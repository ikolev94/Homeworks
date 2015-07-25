using System;
using System.Text;
using Laptop_Shop;

class Laptop
{
    private string model;
    private string manufacturer;
    private string processor;
    private string graphicsCard;
    private string ram;
    private string hdd;
    private string screen;
    private Battery battery;
   
    private decimal price;

    public Laptop(string model, string manufacturer, string processor, string graphicsCard, string ram, string hdd, string screen, string battery, double batteryLife, decimal price)
    {
        this.Model = model;
        this.Maufacturer = manufacturer;
        this.Processor = processor;
        this.graphicsCard = graphicsCard;
        this.Ram = ram;
        this.HDD = hdd;
        this.Screen = screen;
        this.battery = new Battery(battery,batteryLife);
        
        this.Price = price;
    }
    public Laptop(string model, decimal price)
        : this(model, "no", "no", "no", "no", "no", "no", "no", 0, price)
    {
        this.Model = model;
        this.Price = price;
    }


    public string Model
    {
        get { return this.model; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Model cannot be empty");
            }
            this.model = value;
        }
    }
    public string Processor
    {
        get { return this.processor; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("processot cannot be empty");
            }
            this.processor = value;
        }
    }
    public string GraphicsCard
    {
        get { return this.graphicsCard; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("graphics Card cannot be empty");
            }
            this.graphicsCard = value;
        }
    }
    public string HDD
    {
        get { return this.hdd; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("HDD cannot be empty");
            }
            this.hdd = value;
        }
    }
    public string Screen
    {
        get { return this.screen; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Screen cannot be empty");
            }
            this.screen = value;
        }
    }

    public string Ram
    {
        get { return this.ram; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Ram cannot be empty");
            }
            this.ram = value;
        }
    }
    public string Maufacturer
    {
        get { return this.manufacturer; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("manufacturer cannot be empty");
            }
            this.manufacturer = value;
        }
    }

    public decimal Price
    {
        get { return this.price; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Price cannot be negative");
            }
            this.price = value;
        }
    }
    //public double BattrtyLife
    //{
    //    get { return this.batteryLife; }
    //    set
    //    {
    //        if (value < 0)
    //        {
    //            throw new ArgumentException("Battery Life cannot be negative");
    //        }
    //        this.batteryLife = value;
    //    }
    //}
    //public string Battrty
    //{
    //    get { return this.battery; }
    //    set
    //    {
    //        if (string.IsNullOrEmpty(value))
    //        {
    //            throw new ArgumentException("Battery cannot be negative");
    //        }
    //        this.battery = value;
    //    }
    //}


    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendFormat("Model: {0}, Price: {1},", this.Model, this.Price);
        if (this.HDD != "no")
        {
            sb.AppendFormat(" hdd: {0},", this.HDD);
        }
        if (this.Processor != "no")
        {
            sb.AppendFormat(" Processor: {0},", this.Processor);
        }
        if (this.Ram != "no")
        {
            sb.AppendFormat(" ram: {0},", this.Ram);
        }
        if (this.Screen != "no")
        {
            sb.AppendFormat(" Screem: {0},", this.Screen);
        }
        if (this.GraphicsCard != "no")
        {
            sb.AppendFormat(" graphics card: {0},", this.GraphicsCard);
        }
        if (this.Maufacturer != "no")
        {
            sb.AppendFormat(" hdd: {0},", this.Maufacturer);
        }
        if (this.battery.Name != "no")
        {
            sb.AppendFormat(" battery: {0},", this.battery.Name);
        }
        if (this.battery.Life < 0)
        {
            sb.AppendFormat(" battery life: {0},", this.battery.Life);
        }
        return sb.ToString();
    }
}

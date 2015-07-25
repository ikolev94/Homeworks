using System;
using System.Collections.Generic;


namespace PC_Catalog
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Component>parts=new List<Component>()
            {
                new Component("RAM",12m),
                new Component("DVD",14m),
                new Component("CPU",234m)
            };
            Computer MyComp = new Computer("Dell",parts);
            MyComp.GetName();
            MyComp.GetComponents();
            MyComp.GetPrice();
            Console.WriteLine(MyComp);
        }
    }
}

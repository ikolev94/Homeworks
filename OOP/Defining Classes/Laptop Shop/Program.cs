using System;


class Program
{
    static void Main()
    {
        Laptop dell = new Laptop("Lenovo Yoga", "Lenovo", "Intel Core i5- 4210U", "8 GB", "Intel HD Graphics 4400", "128GB SSD", "13.3", "Li-Ion, 4-cells 2550 mAh", 4.5, 2259.00m);
        Laptop lenovo = new Laptop("Dell Vostro", 1112);
        Console.WriteLine(dell);
        Console.WriteLine(lenovo);
    }
}


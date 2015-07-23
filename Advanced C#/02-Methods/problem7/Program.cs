using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        Console.WriteLine(Sort(input));
        Main();
    }

    private static string Sort<T>(IEnumerable<T> item)
    {
        List<T> tempList = item.ToList();
        List<T> sorted = new List<T>();

        while (tempList.Count != 0)
        {
            var x = tempList.Min();
            sorted.Add(x);
            tempList.Remove(x);
        }
        string result = string.Join(", ",sorted);
        return result;
    }
}


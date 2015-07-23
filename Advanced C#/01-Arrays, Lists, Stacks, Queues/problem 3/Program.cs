using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] numbers = Console.ReadLine().Split();
        List<double> intNumbers = new List<double>();
        List<double> floatNumbers = new List<double>();
        for (int i = 0; i < numbers.Length; i++)
        {
            double temp = Double.Parse(numbers[i]);
            double roundTemp = Math.Floor(temp);
            if (temp-roundTemp==0)
            {
                intNumbers.Add(temp);
            }
            else
            {
                floatNumbers.Add(temp);
            }
        }

        for (int i = 0; i < intNumbers.Count; i++)
        {
            intNumbers[i] = Math.Floor(intNumbers[i]);
        }

        Console.WriteLine("["+string.Join(", ",floatNumbers)+"]"+" -> min: {0}, max: {1}, sum: {2}, avg: {3:F2}"
            ,floatNumbers.Min(),floatNumbers.Max(),floatNumbers.Sum(),floatNumbers.Average());
        Console.WriteLine();
        Console.WriteLine("[" + string.Join(", ", intNumbers) + "]" + " -> min: {0}, max: {1}, sum: {2}, avg: {3:F2}"
           , intNumbers.Min(), intNumbers.Max(), intNumbers.Sum(), intNumbers.Average());


    }
}


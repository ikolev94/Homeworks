using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        SortedDictionary<char,int> CharCaunter = new SortedDictionary<char, int>();
        string input = Console.ReadLine();
        foreach (char symbol in input)
        {
            if (CharCaunter.ContainsKey(symbol))
            {
                CharCaunter[symbol]++;
            }
            else
            {
                CharCaunter.Add(symbol,1);
            }
        }
        foreach (var pair in CharCaunter)
        {
            Console.WriteLine("{0}:{1} time/s",pair.Key,pair.Value);
        }
    }
}


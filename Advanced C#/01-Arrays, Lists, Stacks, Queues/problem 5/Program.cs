using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
        List<List<int>> bigList = new List<List<int>>();

        for (int i = 0; i < numbers.Length - 1; i++)
        {
            List<int> smalList = new List<int>();
            smalList.Add(numbers[i]);
            while (numbers[i] < (i + 1 < numbers.Length ? numbers[i + 1] : Int32.MinValue))
            {
                i++;
                smalList.Add(numbers[i]);
            }
            bigList.Add(smalList);
        }

        int indexOfLongestList = 0;
        int indexOfCurrentList = 0;
        int maxCauntofElements = 0;
        foreach (var sublist in bigList)
        {
            int cauntOfElements = 0;
            foreach (var value in sublist)
            {
                cauntOfElements++;
                Console.Write(value);
                Console.Write(' ');
            }
            if (cauntOfElements > maxCauntofElements)
            {
                maxCauntofElements = cauntOfElements;
                indexOfLongestList = indexOfCurrentList;
            }
            indexOfCurrentList++;
            Console.WriteLine();
        }
        Console.WriteLine("Longest: {0}", string.Join(" ", bigList[indexOfLongestList]));
    }
}


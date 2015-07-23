using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(IsItLargerThanNeightbours(numbers, i));
        }
    }

    private static bool IsItLargerThanNeightbours(int[] numbers, int i)
    {
        bool isItBiger = false;
        if (i == 0)
        {
            isItBiger = numbers[i] > numbers[i + 1] ? true : false;
        }
        else if (i == numbers.Length - 1)
        {
            isItBiger = numbers[i] > numbers[i - 1] ? true : false;
        }
        else
        {
            isItBiger = (numbers[i] > numbers[i - 1]) && (numbers[i] > numbers[i + 1]);
        }
        return isItBiger;
    }
}


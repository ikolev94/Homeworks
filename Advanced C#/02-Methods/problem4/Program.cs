using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
        
        Console.WriteLine(GetIndexOfFirstElementLargerThanNeightbours(numbers));
        
    }

    private static int GetIndexOfFirstElementLargerThanNeightbours(int[] numbers)
    {
        int result = 0;
        for (int i = 0; i < numbers.Length; i++)
        {

            if (i == 0)
            {
                if (numbers[i] > numbers[i + 1])
                {
                    result = i;
                    break;
                }
                else
                {
                    result = -1;
                }
            }
            else if (i == numbers.Length - 1)
            {
                if (numbers[i] > numbers[i - 1])
                {
                    result = i;
                    break;
                }
                else
                {
                    result = -1;
                }
            }
            else
            {
                if ((numbers[i] > numbers[i - 1]) && (numbers[i] > numbers[i + 1]))
                {
                    result = i;
                    break;
                }
                else
                {
                    result = -1;
                }
            }
        }
        return result;
    }
}


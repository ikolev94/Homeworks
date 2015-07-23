using System;


class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] inputArray = input.Split();
        int[] inputIntArray = new int[inputArray.Length];
        for (int i = 0; i < inputArray.Length; i++)
        {
            inputIntArray[i] = int.Parse(inputArray[i]);
        }
        int caunt = 0;
        int max = int.MinValue;
        int[] sortArrey = new int[inputIntArray.Length];
        for (int j = inputIntArray.Length; j > 0; j--)
        {
            for (int i = 0; i < inputIntArray.Length; i++)
            {
                if (inputIntArray[i] > max)
                {
                    max = inputIntArray[i];
                }
            }
            sortArrey[j] = max;
            max = int.MinValue;
        }
    }
}


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
        Array.Sort(inputIntArray);
        Console.WriteLine(string.Join(" ", inputIntArray));
    }
}


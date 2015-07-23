using System;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        for (int i = 0; i < input.Length - 1; i++)
        {
            string temp = input[i];
            string next = input[i + 1];
            Console.Write(temp + " ");
            if (!temp.Equals(next))
            {
                Console.WriteLine();
            }
        }
        Console.WriteLine(input[input.Length - 1]);
    }
}


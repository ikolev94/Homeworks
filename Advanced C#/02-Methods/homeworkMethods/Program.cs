using System;

    class Program
    {
        static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            int max = GetMax(firstNumber, secondNumber);
            Console.WriteLine(max);
        }

        static int GetMax(int first, int second)
        {
            int max = Math.Max(first, second);
            return max;
        }
    }


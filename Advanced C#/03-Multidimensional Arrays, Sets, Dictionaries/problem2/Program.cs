using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        int maxSum = Int32.MinValue;
        int x = 0, y = 0;
        int[,] matrix = new int[n, m];
        
        GetValue(matrix);

        for (int i = 0; i < matrix.GetLength(0)-2; i++)
        {
            for (int j = 0; j < matrix.GetLength(1)-2; j++)
            {
                int tampSum = matrix[i, j] + matrix[i, j + 1] + matrix[i, j + 2]
                              + matrix[i + 1, j] + matrix[i + 1, j + 1] + matrix[i + 1, j + 2]
                              + matrix[i + 2, j] + matrix[i + 2, j + 1] + matrix[i + 2, j + 2];
                if (tampSum>maxSum)
                {
                    maxSum = tampSum;
                    x = i;
                    y = j;
                }
            }
        }
        Console.WriteLine("  Sum = {0}",maxSum);
        Print3x3(x, y, matrix);


    }

    private static void Print3x3(int x, int y, int[,] matrix)
    {
        for (int i = x; i < x + 3; i++)
        {
            for (int j = y; j < y + 3; j++)
            {
                Console.Write("{0,3}", matrix[i, j]);
            }
            Console.WriteLine();
        }
    }

    private static void GetValue(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            int[] tempLine = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = tempLine[j];
            }
        }
    }

   
}


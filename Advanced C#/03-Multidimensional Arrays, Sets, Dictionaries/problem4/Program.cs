using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    private static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());

        string[,] matrix = new string[n, m];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                matrix[i, j] = Console.ReadLine();
            }
        }

        int bestCaunt = 0;
        string bestValue = String.Empty;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1) - 1; j++)
            {
                int currCaunt = horizontal(matrix, i);
                if (currCaunt > bestCaunt)
                {
                    bestCaunt = currCaunt;
                    bestValue = matrix[i, j];
                }
                currCaunt = vertical(matrix, j);
                if (currCaunt > bestCaunt)
                {
                    bestCaunt = currCaunt;
                    bestValue = matrix[i, j];
                }
                currCaunt = diagonal(matrix, i, j);
                if (currCaunt > bestCaunt)
                {
                    bestCaunt = currCaunt;
                    bestValue = matrix[i, j];
                }
                currCaunt = 0;
            }
        }
        for (int i = 0; i < bestCaunt + 1; i++)
        {
            Console.Write(bestValue + " ");
        }
        Console.WriteLine();
    }

    private static int horizontal(string[,] matrix, int i)
    {
        int currCaunt = 0;
        for (int j = 0; j < matrix.GetLength(1) - 1; j++)
        {
            string curentString = matrix[i, j];
            string horizontalLeft = matrix[i, j + 1];
            if (curentString.Equals(horizontalLeft))
            {
                currCaunt++;
            }
            else
            {
                break;
            }
        }
        return currCaunt;
    }

    private static int vertical(string[,] matrix, int j)
    {
        int currCaunt = 0;
        for (int i = 0; i < matrix.GetLength(0) - 1; i++)
        {
            string curentString = matrix[i, j];
            string verticalDown = matrix[i + 1, j];
            if (curentString.Equals(verticalDown))
            {
                currCaunt++;
            }
            else
            {
                break;
            }
        }
        return currCaunt;
    }

    private static int diagonal(string[,] matrix, int i, int j)
    {
        int currCaunt = 0;
        for (int i1 = i, j1 = 0; i1 < matrix.GetLength(0) - 1 && j1 < matrix.GetLength(1) - 1; i1++, j1++)
        {
            string curentString = matrix[i1, j1];
            string verticalDown = matrix[i1 + 1, j1 + 1];
            if (curentString.Equals(verticalDown))
            {
                currCaunt++;
            }
            else
            {
                break;
            }
        }
        return currCaunt;
    }
}

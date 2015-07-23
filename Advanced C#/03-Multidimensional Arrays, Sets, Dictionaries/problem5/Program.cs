using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Program
{
    private static void Main()
    {
        char[][] table = new char[4][];

        for (int i = 0; i < table.Length; i++)
        {
            table[i] = Console.ReadLine().ToCharArray();
        }

        int moneyCaunter = 0;
        int wallcaunter = 0;
        string comands = Console.ReadLine();
        int row = 0, col = 0;

        foreach (char symbol in comands)
        {
            if (symbol == 'V')
            {
                row++;
                if (row > table.GetLength(0))
                {
                    row--;
                    wallcaunter++;
                    continue;
                }
                else if (col >= table[row].Length)
                {
                    row--;
                    wallcaunter++;
                    continue;
                }
            }
            else if (symbol == '>')
            {
                col++;
                if (col >= table[row].Length)
                {
                    col--;
                    wallcaunter++;
                    continue;
                }
            }
            else if (symbol == '^')
            {
                row--;
                if (row < 0)
                {
                    row++;
                    wallcaunter++;
                    continue;
                }
                else if (col >= table[row].Length)
                {
                    row++;
                    wallcaunter++;
                    continue;
                }
            }
            else if (symbol == '<')
            {
                col--;
                if (col < 0)
                {
                    col++;
                    wallcaunter++;
                    continue;
                }
            }
            if (table[row][col] == '$')
            {
                moneyCaunter++;
            }
        }



        Console.WriteLine("Coins collected : {0}", moneyCaunter);
        Console.WriteLine("Walls hit: {0}", wallcaunter);
    }

}

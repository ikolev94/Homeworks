using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        string[,] matrix = new string[n, m];

        GetValue(matrix);

        string input = String.Empty;
        do
        {
            input = Console.ReadLine();
            string[] comand = input.Split();
            if (input == "END")
            {
                break;
            }
            int x1 = int.Parse(comand[1]);
            int y1 = int.Parse(comand[2]);
            int x2 = int.Parse(comand[3]);
            int y2 = int.Parse(comand[4]);

            bool corect = GetValue(comand, x1, m, x2, y1, n, y2);

            if (corect)
            {
                string temp = matrix[x1, y1];
                matrix[x1, y1] = matrix[x2, y2];
                matrix[x2, y2] = temp;
                Print(matrix);

            }
            else
            {
                if (input != "END")
                {
                    Console.WriteLine("Invalid input");
                }
            }

        } while (input != "END");

    }

    private static bool GetValue(string[] comand, int x1, int m, int x2, int y1, int n, int y2)
    {
        bool corect = false;
        if (comand[0] == "swap")
        {
            if (comand.Length < 6)
            {
                if (x1 < m)
                {
                    if (x2 < m)
                    {
                        if (y1 < n)
                        {
                            if (y2<n)
                            {
                                corect = true;
                            }
                        }
                    }
                }   
            }
        }
        return corect;
    }

    private static void Print(string[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write("{0,4}", matrix[i, j]);
            }
            Console.WriteLine();
        }
    }

    private static void GetValue(string[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = Console.ReadLine();
            }
        }
    }
}


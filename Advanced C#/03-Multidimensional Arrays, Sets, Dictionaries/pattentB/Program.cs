using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, m];
        int caunt = 0;

        
        bool oddColl = true;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            if (oddColl)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = caunt;
                    caunt++;
                }
                Console.WriteLine();
            }
            else
            {
                for (int j = matrix.GetLength(1)-1; j >= 0; j--)
                {
                    matrix[i, j] = caunt;
                    caunt++;
                }
                Console.WriteLine();
            }
            oddColl = !oddColl;
        }
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                Console.Write("{0,4}",matrix[j, i]);
            }
            Console.WriteLine();
        }

    }
}


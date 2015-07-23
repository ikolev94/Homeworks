using System;

namespace ConsoleApplication1
{
    internal class Program
    {
        private static void Main()
        {
            var firstMatrix = new double[,] {{1, 3}, {5, 7}};
            var socindMatrix = new double[,] {{4, 2}, {1, 5}};
            var resultMatrix = MatrixMultiplicator(firstMatrix, socindMatrix);

            for (int row = 0; row < resultMatrix.GetLength(0); row++)
            {
                for (int col = 0; col < resultMatrix.GetLength(1); col++)
                {
                    Console.Write(resultMatrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }

        private static double[,] MatrixMultiplicator(double[,] firstNumbers, double[,] secondNumbers)
        {
            if (firstNumbers.GetLength(1) != secondNumbers.GetLength(0))
            {
                throw new Exception("Error!");
            }

            var firstNumbersLenght = firstNumbers.GetLength(1);
            var resultNumbers = new double[firstNumbers.GetLength(0), secondNumbers.GetLength(1)];
            for (int row = 0; row < resultNumbers.GetLength(0); row++)
            {
                for (int col = 0; col < resultNumbers.GetLength(1); col++)
                {
                    for (int index = 0; index < firstNumbersLenght; index++)
                    {
                        resultNumbers[row, col] += firstNumbers[row, index]*secondNumbers[index, col];
                    }
                }
            }

            return resultNumbers;
        }
    }
}
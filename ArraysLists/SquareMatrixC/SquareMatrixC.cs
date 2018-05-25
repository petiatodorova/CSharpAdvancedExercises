using System;

namespace SquareMatrixC
{
    class SquareMatrixC
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            int currentNumber = 1;

            // Left Down Rectangle
            for (int i = 0; i < n; i++)
            {
                for (int k = i; k >= 0; k--)
                {
                    matrix[n - 1 - k, 0 + i - k] = currentNumber;
                    currentNumber++;
                }
            }

            for (int i = 0; i < n - 1; i++)
            {
                for (int k = i; k <= n - 2; k++)
                {
                    matrix[k - i, k + 1] = currentNumber;
                    currentNumber++;

                }
            }


            // Print of the Matrix
            PrintMatrix(n, matrix);
        }

        static void PrintMatrix(int n, int[,] matrix)
        {
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write($"{matrix[row, col]} ");
                }
                Console.WriteLine($"");
            }
        }
    }
}

using System;

namespace DiagonalMatrixOne
{
    class DiagonalMatrix
    {
        static void Main(string[] args)
        {
            int n = 7;
            int[,] matrix = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                int num = 1;
                for (int k = i; k >= 0; k--)
                {
                    matrix[n - 1 - k, 0 + i - k] = num;
                 }
                num++;
            }

            for (int i = 0; i < n - 1; i++)
            {
                int num = 11;
                for (int k = i; k <= n - 2; k++)
                {
                    matrix[k - i, k + 1] = num;
                }
                num++;
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
                    Console.Write($"{matrix[row, col].ToString().PadLeft(5, ' ')} ");
                }
                Console.WriteLine($"");
                Console.WriteLine($"");
                Console.WriteLine($"");
            }
        }
    }
}

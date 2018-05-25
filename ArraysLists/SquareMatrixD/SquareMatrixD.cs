using System;

namespace SquareMatrixD
{
    class SquareMatrixD
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            int currentNumber = 1;
            int count = 0;

            if (n % 2 == 0)
            {
                count = n / 2;
            }
            else
            {
                count = n / 2 + 1;
            }
             

            for (int k = 0; k < count; k++)
            {
                // Left quadrat column
                for (int i = k; i < n - k; i++)
                {
                    matrix[i, k] = currentNumber;
                    currentNumber++;
                }

                // Down quadrat column
                for (int i = k + 1; i < n - k; i++)
                {
                    matrix[n - 1 - k, i] = currentNumber;
                    currentNumber++;
                }

                // Right quadrat column
                for (int i = n - 2 - k; i >= k; i--)
                {
                    matrix[i, n - 1 - k] = currentNumber;
                    currentNumber++;
                }

                // Up quadrat column
                for (int i = n - 2 - k; i >= 1 + k; i--)
                {
                    matrix[k, i] = currentNumber;
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
                    Console.Write($"{matrix[row, col].ToString().PadLeft(4, ' ')} ");
                }
                Console.WriteLine($"");
            }
        }
    }
}

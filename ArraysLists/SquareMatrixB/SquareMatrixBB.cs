using System;

namespace SquareMatrixB
{
    class SquareMatrixBB
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            int currentNumber = 1;
            for (int cols = 0; cols < n; cols++)
            {
                if (cols % 2 == 0)
                {
                    // 1-va col
                    for (int i = 0; i < n; i++)
                    {
                        matrix[i, cols] = currentNumber;
                        currentNumber++;
                    }
                }
                else
                {
                    for (int j = n - 1; j >= 0; j--)
                    {
                        matrix[j, cols] = currentNumber;
                        currentNumber++;
                    }
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

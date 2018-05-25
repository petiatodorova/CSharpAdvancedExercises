using System;

namespace NByNMatrix
{
    class NNMatrix
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            int[,] newMatrix = new int[n - 1, n - 1];  





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

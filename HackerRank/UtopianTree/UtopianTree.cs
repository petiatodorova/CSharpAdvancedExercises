using System;

namespace UtopianTree
{
    class UtopianTree
    {
        static void Main(string[] args)
        {
            int testCases = int.Parse(Console.ReadLine());

            for (int i = 0; i < testCases; i++)
            {
                int numberOfCycles = int.Parse(Console.ReadLine());
                int height = 1;

                for (int j = 1; j <= numberOfCycles; j++)
                {
                    if (j % 2 == 1 )
                    {
                        height = height * 2;
                    }
                    else
                    {
                        height++;
                    }
                }

                Console.WriteLine($"{height}");
            }
        }
    }
}

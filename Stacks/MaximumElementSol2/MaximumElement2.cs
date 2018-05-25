using System;
using System.Linq;
using System.Collections.Generic;

namespace MaximumElementSol2
{
    class MaximumElement2
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            Stack<int> numbers = new Stack<int>();
            Stack<int> maxNumbers = new Stack<int>();
            int maxValue = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                switch (input[0])
                {
                    case 1:
                        int theNumber = input[1];
                        numbers.Push(theNumber);
                        if (theNumber > maxValue)
                        {
                            maxNumbers.Push(theNumber);
                            maxValue = theNumber;
                        }
                        break;

                    case 2:
                        if (numbers.Count > 0)
                        {
                            if (numbers.Pop() == maxValue)
                            {
                                maxNumbers.Pop();
                                if (maxNumbers.Count > 0)
                                {
                                    maxValue = maxNumbers.Peek();
                                }
                                else
                                {
                                    maxValue = int.MinValue;
                                }
                            }
                        }
                        break;

                    case 3:
                        if (maxNumbers.Count > 0)
                        {
                            Console.WriteLine($"{maxNumbers.Peek()}");
                        }
                        break;
                }
            }
        }
    }
}

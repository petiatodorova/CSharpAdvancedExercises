using System;
using System.Collections.Generic;
using System.Linq;

namespace _04MatchingBrackets
{
    class MatchingBrackets
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine()
                .ToCharArray();

            Stack<int> indexBrackets = new Stack<int>();

            int openBracketIndex = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    indexBrackets.Push(i);
                }
                if (input[i] == ')')
                {
                    if (indexBrackets.Count() > 0)
                    {
                        openBracketIndex = indexBrackets.Pop();
                        for (int j = openBracketIndex; j <= i; j++)
                        {
                            Console.Write($"{input[j]}");
                        }
                        Console.WriteLine($"");
                    }
                }
            }
        }
    }
}

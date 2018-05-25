using System;
using System.Collections.Generic;

namespace E7BalancedParentheses
{
    class BalancedParentheses
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<char> brackets = new Stack<char>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '{' || input[i] == '[' || input[i] == '(')
                {
                    brackets.Push(input[i]);
                }
                else
                {
                    if (brackets.Count == 0)
                    {
                        Console.WriteLine($"NO");
                        return;
                    }
                        char currentTop = brackets.Pop();
                        switch (currentTop)
                        {
                            case '{':
                                if (input[i] != '}')
                                {
                                    Console.WriteLine($"NO");
                                    return;
                                }

                                break;
                            case '[':
                                if (input[i] != ']')
                                {
                                    Console.WriteLine($"NO");
                                    return;
                                }

                                break;
                            case '(':
                                if (input[i] != ')')
                                {
                                    Console.WriteLine($"NO");
                                    return;
                                }

                                break;
                        }
                }
            }
            Console.WriteLine($"YES");
        }
    }
}

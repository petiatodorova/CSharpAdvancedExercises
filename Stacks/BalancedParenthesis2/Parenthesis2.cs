using System;
using System.Collections.Generic;

namespace BalancedParenthesis2
{
    class Parenthesis2
    {
        static void Main(string[] args)
        {
            Stack<char> helper = new Stack<char>();

            char[] line = Console.ReadLine().ToCharArray();

            helper.Push(line[0]);
            bool isBalanced = false;

            if (line.Length % 2 != 0)
            {
                Console.WriteLine($"NO");
                return;
            }

            int middle = line.Length / 2;

            for (int j = 1; j < middle; j++)
            {
                helper.Push(line[j]);
            }

            for (int i = middle; i < line.Length; i++)
            {
                char current = line[i];
                char beforeParenthesis = helper.Peek();
                switch (current)
                {
                    case ')':
                        if (beforeParenthesis == '(')
                        {
                            helper.Pop();
                            isBalanced = true;
                        }
                        else
                        {
                            Console.WriteLine($"NO");
                            return;
                        }
                        break;

                    case '}':
                        if (beforeParenthesis == '{')
                        {
                            helper.Pop();
                            isBalanced = true;
                        }
                        else
                        {
                            Console.WriteLine($"NO");
                            return;
                        }

                        break;

                    case ']':
                        if (beforeParenthesis == '[')
                        {
                            helper.Pop();
                            isBalanced = true;
                        }
                        else
                        {
                            Console.WriteLine($"NO");
                            return;
                        }

                        break;
                }
            }

            if (isBalanced)
            {
                Console.WriteLine($"YES");
            }

        }
    }
}

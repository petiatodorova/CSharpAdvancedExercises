using System;
using System.Collections.Generic;
using System.Linq;

namespace PalindromeWithStackAndQueue
{
    class Program
    {
        public static void Main(string[] args)
        {
            Stack<char> stackPal = new Stack<char>();
            Queue<char> queuePal = new Queue<char>();


        }

        static void pushCharacter(char ch)
        {
            stackPal.Push(ch);
        }

        static void enqueueCharacter(char ch)
        {
            queuePal.Enqueue(ch);
        }

        static char popCharacter()
        {
            return stackPal.Pop();
        }

        static char dequeueCharacter()
        {
            return queuePal.Dequeue();
        }
    }
}

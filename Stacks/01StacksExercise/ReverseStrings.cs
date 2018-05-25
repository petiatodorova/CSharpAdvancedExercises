using System;
using System.Linq;
using System.Collections.Generic;

namespace _01StacksExercise
{
    class ReverseStrings
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(' ')
                .ToArray();

            Stack<string> inputStack = new Stack<string>();

            foreach (var word in input)
            {
                inputStack.Push(word);
            }

            foreach (var element in inputStack.ToArray())
            {
                string current = inputStack.Pop();
                Console.Write($"{string.Join("", current.Reverse())} ");
            }
        }
    }
}
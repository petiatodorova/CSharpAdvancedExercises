using System;
using System.Collections.Generic;
using System.Linq;

namespace RepeatedString
{
    class RepeatString
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            long n = long.Parse(Console.ReadLine());
            long length = s.Length;

            if (length >= n)
            {
                long counter = CountAInSubstr(s, n);
                Console.WriteLine($"{counter}");
            }
            else
            {
                long times = n / length;
                long remainder = n % length;
                long counter = times * CountAInSubstr(s, length) + CountAInSubstr(s, remainder);
                Console.WriteLine($"{counter}");
            }
        }

        static long CountAInSubstr(string s, long n)
        {
            string subStr = s.Substring(0, (int)n);
            long counter = subStr.Where(x => x == 'a').Count();
            return counter;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Proba
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "+12adkh|aksfd +1552hdbsds";
            string pattern = @"(\+)?([\w]{1,3})";

            Regex regex = new Regex(pattern);
            Match matchM = regex.Match(input);
            Console.WriteLine($"{matchM.Groups.Count}");  

            if (regex.IsMatch(input))
            {
                MatchCollection matches = regex.Matches(input);
                Console.WriteLine($"{matches.Count()}"); 

                foreach (Match match in matches)
                {
                    Console.WriteLine($"{match.Groups[2].Value}");
                }
            }





        }
    }
}

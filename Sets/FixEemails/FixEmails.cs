using System;
using System.Collections.Generic;
using System.Linq;

namespace FixEemails
{
    class FixEmails
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();

            while (true)
            {
                if (input == "stop")
                {
                    break;
                }
                string name = input;
                string email = Console.ReadLine();

                if (!email.ToLower().EndsWith("us") && !email.ToLower().EndsWith("uk"))
                {
                    if (!phoneBook.ContainsKey(name))
                    {
                        phoneBook.Add(name, email);
                    }
                    else
                    {
                        phoneBook[name] = email;
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var kvp in phoneBook)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}

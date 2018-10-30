using System;

namespace ReadKeyExample
{
    class ReadKey
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Press 'a' or 'b'. Everything else finishes the program.");
            
            ConsoleKeyInfo info = Console.ReadKey();

            while (true)
            {
                if (info.KeyChar != 'a' && info.KeyChar != 'b' )
                {
                    Console.WriteLine($"");
                    Console.WriteLine($"You typed {info.Key} so the program is finished.");
                    Console.WriteLine($"The hash code is {info.GetHashCode()}");
                    break;
                }
                else
                {
                    Console.WriteLine($"");
                    Console.WriteLine($"You typed {info.Key}.");
                    Console.WriteLine($"The hash code is {info.GetHashCode()}");
                }

                info = Console.ReadKey();
            }
        }
    }
}

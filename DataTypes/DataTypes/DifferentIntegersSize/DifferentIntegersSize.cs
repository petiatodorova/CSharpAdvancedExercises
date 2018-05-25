using System;

namespace DifferentIntegersSize
{
    class DifferentIntegersSize
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            string endMessage = "";
            bool fits = false;

            try
            {
                sbyte.Parse(n);
                endMessage += "* sbyte\r\n";
                fits = true;

            }
            catch
            { }

            try
            {
                byte.Parse(n);
                endMessage += "* byte\r\n";
                fits = true;
            }
            catch
            { }

            try
            {
                short.Parse(n);
                endMessage += "* short\r\n";
                fits = true;
            }
            catch
            { }

            try
            {
                ushort.Parse(n);
                endMessage += "* ushort\r\n";
                fits = true;
            }
            catch
            { }

            try
            {
                int.Parse(n);
                endMessage += "* int\r\n";
                fits = true;
            }
            catch
            { }

            try
            {
                uint.Parse(n);
                endMessage += "* uint\r\n";
                fits = true;
            }
            catch
            { }

            try
            {
                long.Parse(n);
                endMessage += "* long\r\n";
                fits = true;
            }
            catch
            { }

            if (fits)
            {
                Console.WriteLine($"{n} can fit in:");
                Console.WriteLine($"{endMessage}");
            }
            else
            {
                Console.WriteLine($"{n} can't fit in any type");
            }
        }
    }
}

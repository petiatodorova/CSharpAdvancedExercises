using System;

namespace Attributes
{
    [Serializable]
    class Program
    {
        static void Main(string[] args)
        {
            var a = 5;

            var attributes = typeof(Program).GetCustomAttributes(false);
            var attributes1 = typeof(Program).GetElementType();

            foreach (var attr in attributes)
            {
                Console.WriteLine($"{attr.ToString()}");
            }

        }
    }
}

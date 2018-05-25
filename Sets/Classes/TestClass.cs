using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public class TestClass<T, K>
    {
        public T Value { get; set; }
        public K AnotherValue { get; set; }

        public void Pronto()
        {
            Console.WriteLine($"{Value}");
        }

        public void Pronto2()
        {
            Console.WriteLine($"{AnotherValue}");
        }
    }
}

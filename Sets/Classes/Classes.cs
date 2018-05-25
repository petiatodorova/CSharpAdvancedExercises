using System;
using System.Collections.Generic;
using System.Linq;


namespace Classes
{
    public class Classes
    {
        static void Main(string[] args)
        {

            Student st = new Student();

            st["uno"] = "one";


            Console.WriteLine($"{st["uno"]}");




        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace OopExercises
{
    public class Startup
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            List<string> studentClasses = new List<string>();
            Student student = new Student("Pesho", "pesho@abv.bg", studentClasses);
            Teacher teacher = new Teacher("Shefa", "shef@abv.bg", "admin");

            student.Classes.Add("Physics");
            student.Classes.Add("Chemistry");
            student.Classes.Add("Math");
            student.Classes.Add("Algebra");

            Console.WriteLine($"{person.Talking()}");
            Console.WriteLine($"{student.Talking()}");
            Console.WriteLine($"{teacher.Talking()}");
            Console.WriteLine($"{teacher.Sleeping()}");
            Console.WriteLine($"{student.Sleeping()}");
            Console.WriteLine($"{person.Sleeping()}");
            Console.WriteLine($"{person.Name}");
            Console.WriteLine($"{student.Name}");
            Console.WriteLine($"Student classes --> {string.Join("  |  ", student.Classes.OrderBy(x => x))}");

        }
    }
}

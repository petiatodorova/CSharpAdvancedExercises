using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentsClassWithList
{
    class ClassWithList
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
           {
               new Student
               {
                   FirstName = "Pesho",
                   LastName = "Goshov",
                   Marks = new List<double> { 3.5, 5.6, 5.8 },
                   Strengths = new Dictionary<string, double>()
                   {
                       { "magic", 222.43 },
                       { "mind", 333.56 },
                       { "logic", 3307.16 }
                   },
               },
               new Student
               {
                   FirstName = "Atanas",
                   LastName = "Milanov",
                   Marks = new List<double> { 5.7, 3.4 },
                   Strengths = new Dictionary<string, double>()
                   {
                       { "power", 112.56 },
                       { "intuition", 111.23 },
                       { "mind", 1024.54 }
                   }
               },
               new Student
               {
                   FirstName = "Mimi",
                   LastName = "Petrova",
                   Marks = new List<double> { 5.8, 5.6 },
                   Strengths = new Dictionary<string, double>()
                   {
                       { "logic", 102.33 },
                       { "mind", 432.56 },
                       { "intuition", 2354.67 }
                   }
               },

               new Student
               {
                   FirstName = "Mimi",
                   LastName = "Atanasova",
                   Marks = new List<double> { 4.8, 4.6, 5.8 },
                   Strengths = new Dictionary<string, double>()
                   {
                       { "mind", 302.33 },
                       { "power", 132.56 },
                       { "logic", 1024.35 }
                   }
               }
           };

            foreach (var student in students.OrderBy(x => x.FirstName).ThenBy(y => y.LastName))
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}");
                foreach (var kvp in student.Strengths.OrderByDescending(z => z.Value))
                {
                    Console.WriteLine($"--> {kvp.Key} --> {kvp.Value}");
                }
                Console.WriteLine($"");
            }
        }
    }
}

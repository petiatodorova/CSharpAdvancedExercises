using System;
using System.Collections.Generic;
using System.Linq;

namespace Test
{
    class Test
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("Mimi", 3));
            students.Add(new Student("Yavor", 5));
            students.Add(new Student("Kotyo", 6));

            foreach (var item in students.OrderByDescending(x => x.Mark))
            {
                Console.WriteLine($"{item.Name} --> {item.Mark}");
            }
        }
    }

    public class Student
    {
        public string Name { get; set; }
        public int Mark { get; set; }

        public Student(string name, int mark)
        {
            Name = name;
            Mark = mark;
        }
    }
}

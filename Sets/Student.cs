using System;

public class Student
{
    public Student()
    {
         public string FirstName { get; set; }
    public string LastName { get; set; }
    public List<double> Marks { get; set; }
    public double Mark => this.Marks.Average();
    public Dictionary<string, double> Strengths { get; set; }
}
}

//using System.Collections.Generic;
//using System.Linq;

//public class Student
//{
//    public string FirstName { get; set; }
//    public string LastName { get; set; }
//    public List<double> Marks { get; set; }
//    public double Mark => this.Marks.Average();
//    public Dictionary<string, double> Strengths { get; set; }
//}

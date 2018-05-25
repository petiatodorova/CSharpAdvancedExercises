using System.Collections.Generic;
using System;


public class Book
{
    public int MyProperty { get; set; }
    public string Name { get; set; }
    public string Author { get; set; }
    private int Age { get; set; }
    public Color Color { get; set; }
    public static int NumberOfYears { get; set; }

    public Book(int myProperty, string name, string author, int age) : this(myProperty, name, author)
    {
        Age = age;
    }

    public Book(int myProperty, string name, string author)
    {
        MyProperty = myProperty;
        Name = name;
        Author = author;
    }

    public Book()
    {
        MyProperty = 3;
    }

    public static void SayMyau()
    {
        Console.WriteLine($"Hello Myuauuu!");
    }

    public static int Years()
    {
        return 22;
    }

    public int NextAge
    {
        get
        {
            return Age + 1;
        }
        
    }
}


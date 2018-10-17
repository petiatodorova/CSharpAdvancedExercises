using System;
using System.Collections.Generic;

public class CatOK
{
    public string Name { get; set; }
    public string Color { get; set; }
    public List<int> Days { get; set; }
    public int Wins { get; set; }

    public CatOK(string name, string color, List<int> days) : this(name, color)
    {
        Days = days;
    }

    public CatOK()
    {
        Name = "Unnamed";
        Color = "gray";
    }

    public CatOK(string name, string color)
    {
        Name = name;
        Color = color;
    }

    // Method SayMiau
    public void SayMiau()
    {
        Console.WriteLine($"Cat {Name} said: Miauuuuuu!");
    }

}
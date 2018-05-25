using System;
using System.Collections.Generic;

namespace CompareClasses
{
    class CompareBooks
    {
        static void Main(string[] args)
        {
            SortedSet<Book> books = new SortedSet<Book>();

            books.Add(new Book("Title1", "Author1"));
            books.Add(new Book("Title1", "Author2"));
            books.Add(new Book("Title3", "Author3"));
            books.Add(new Book("Title4", "Author4"));

            foreach (var book in books)
            {
                Console.WriteLine($"{book.Title} --> {book.Author}");
            }
        }
    }
}

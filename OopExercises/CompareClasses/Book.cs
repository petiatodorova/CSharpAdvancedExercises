using System;

namespace CompareClasses
{
    public class Book : IComparable<Book>
    {
        public string Title { get; set; }
        public string Author { get; set; }

        public Book(string title, string author)
        {
            Title = title ?? throw new ArgumentNullException(nameof(title));
            Author = author ?? throw new ArgumentNullException(nameof(author));
        }

        public Book()
        {
        }

        public int CompareTo(Book other)
        {
            // compare first by Title
            int titleCompare = this.Title.CompareTo(other.Title);
            if (titleCompare != 0)
            {
                return titleCompare;
            }

            // if title is the same - by Author
            return this.Author.CompareTo(other.Author);
        }
    }
}

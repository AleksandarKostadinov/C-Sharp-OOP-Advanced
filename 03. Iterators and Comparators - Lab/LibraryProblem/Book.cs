using System;
using System.Collections.Generic;

public class Book : IBook , IComparable<Book>
{
    public Book(string title, int year,params string[] author)
    {
        this.Title = title;
        this.Year = year;
        this.Author =new List<string>();
    }

    public string Title { get;private set; }
    public int Year { get; private set; }
    public IReadOnlyList<string> Author { get; private set; }
    public int CompareTo(Book otherBook)
    {
        var result = this.Year.CompareTo(otherBook.Year);
        if (result == 0)
        {
            result = this.Title.CompareTo(otherBook.Title);
        }

        return result;
    }

    public override string ToString()
    {
        return $"{this.Title} - {this.Year}";
    }
}

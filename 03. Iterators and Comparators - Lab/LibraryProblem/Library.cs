using System.Collections;
using System.Collections.Generic;

public class Library : IEnumerable<Book>
{
    private SortedSet<Book> books;

    public Library(params Book[] books)
    {
        this.books = new SortedSet<Book>(books, new BookComparator());
    }


    public IEnumerator<Book> GetEnumerator()
    {
        return new LibraryIterator(new List<Book>(this.books));
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    private class LibraryIterator : IEnumerator<Book>
    {
        private IList<Book> books;

        private int currentIndex;

        public LibraryIterator(IList<Book> books)
        {
            this.Reset();
            this.books = books;
        }

        public void Dispose() {}

        public bool MoveNext() => ++this.currentIndex < this.books.Count;

        public void Reset() => this.currentIndex = -1;

        public Book Current
        {
            get => this.books[currentIndex];
        }

        object IEnumerator.Current
        {
            get { return Current; }
        }
    }
}
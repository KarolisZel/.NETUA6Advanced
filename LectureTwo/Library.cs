namespace LectureTwo;

class Library
{
    public List<Book> Books { get; set; }

    public Library(List<Book> books)
    {
        Books = books;
    }

    public void AddBook(Book book)
    {
        Books.Add(book);
    }

    public void RemoveBook(Book book)
    {
        if (!Books.Contains(book))
        {
            Console.WriteLine($"Book with the name {book} does not exist in this library.");
            return;
        }

        Books.Remove(book);
    }
}

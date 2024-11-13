namespace LectureTwo;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        var book = new Book("Skaitalas", "Liaudis", 500);

        Console.WriteLine(
            $"Time to read: {book.TimeToRead()[0]}:{book.TimeToRead()[1]}:{book.TimeToRead()[2]} "
        );
    }
}

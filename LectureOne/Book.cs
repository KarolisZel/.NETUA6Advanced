namespace LectureOne;

class Book
{
    public string Name { get; private set; }
    public string Author { get; private set; }
    public int Year { get; private set; } // Use DateOnly?
    public string Country { get; private set; }

    public Book() { }

    public Book(string name, string author, int year)
    {
        Name = name;
        Author = author;
        Year = year;
    }

    public Book(string name, string author, int year, string country)
        : this(name, author, year)
    {
        Country = country;
    }
}

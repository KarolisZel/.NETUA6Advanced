namespace LectureTwo;

class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Pages { get; set; }

    public Book(string title, string author, int pages)
    {
        Title = title;
        Author = author;
        Pages = pages;
    }

    public int[] TimeToRead()
    {
        // 50 => 3600 sec
        // Pages => Y sec
        // Pages * 3600 => 50 * Y
        // (Pages * 3600) / 50 => Y

        // Pages = 500 => 10 * 3600 = 36000 => 10 hours

        var secondsToRead = (Pages * 3600) / 50;

        var timeToRead = new int[3];

        // Calculate Hours
        timeToRead[0] = secondsToRead / 3600;
        secondsToRead %= 3600;

        // Calculate Minutes
        timeToRead[1] = secondsToRead / 60;
        secondsToRead %= 60;

        // Remaining Seconds
        timeToRead[2] = secondsToRead;

        return timeToRead;
    }
}

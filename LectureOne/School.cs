namespace LectureOne;

class School
{
    public string Name { get; private set; }
    public string City { get; private set; }

    public int StudentCount { get; private set; }

    public School() { }

    public School(string name, string city)
    {
        Name = name;
        City = city;
    }

    public School(string name, string city, int studentCount)
        : this(name, city)
    {
        StudentCount = studentCount;
    }
}

namespace LectureFive;

public class Teacher : Person
{
    private string Subject { get; set; }

    protected Teacher(string name, int age)
        : base(name, age) { }

    public void GetSubject()
    {
        Console.WriteLine($"Subject => {Subject}");
    }
}

namespace LectureFive;

public class Student : Person
{
    private int StudentId { get; set; }

    public Student(string name, int age)
        : base(name, age) { }

    public void GetStudentId()
    {
        Console.WriteLine($"StudentId => {StudentId}");
    }
}
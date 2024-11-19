namespace LectureFive;

public class Person
{
    protected string Name { get; private set; }
    protected int Age { get; private set; }

    protected Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    protected void PrintInfo()
    {
        Console.WriteLine($"Name => {Name}");
        Console.WriteLine($"Age => {Age}");
    }
}
namespace LectureThree;

class Programmer : Employee
{
    public string ProgrammingLanguage { get; set; }

    public Programmer(string programmingLanguage)
    {
        ProgrammingLanguage = programmingLanguage;
    }

    public void PrintProgrammer()
    {
        Console.WriteLine($"{Name} => {Salary} => {ProgrammingLanguage}");
    }
}

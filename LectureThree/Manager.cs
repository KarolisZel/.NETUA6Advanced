namespace LectureThree;

class Manager : Employee
{
    public static List<Programmer> Employees { get; set; } = new();

    public void PrintManagerData()
    {
        Console.WriteLine($"{Name} => {Salary} => {Employees.Count}");
    }

    public void PrintTeamData(Programmer programmer)
    {
        Console.WriteLine($"{Name} => {Salary} => {Employees.Count}");
        foreach (var employee in Employees)
        {
            Console.WriteLine(
                $"{employee.Name} => {employee.Salary} => {employee.ProgrammingLanguage}"
            );
        }
    }
}

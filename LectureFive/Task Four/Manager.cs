namespace LectureFive.Task_Four;

public class Manager : Employee
{
    public Manager(double salary)
        : base(salary) { }

    protected sealed override void GetSalary()
    {
        Console.WriteLine($"Salary => {Salary}");
    }
}
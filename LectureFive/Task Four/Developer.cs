namespace LectureFive.Task_Four;

public class Developer : Employee
{
    public Developer(double salary)
        : base(salary) { }

    protected sealed override void GetSalary()
    {
        Console.WriteLine($"Salary => {Salary}");
    }
}
namespace LectureFive.Task_Four;

public class Employee
{
    public double Salary { get; set; }

    public Employee(double salary)
    {
        Salary = salary;
    }

    protected virtual void GetSalary()
    {
        Console.WriteLine($"Salary => {Salary}");
    }
}

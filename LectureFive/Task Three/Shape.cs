namespace LectureFive.Task_Three;

public class Shape
{
    public double Area { get; set; }

    public Shape() { }

    protected virtual double CalculateArea()
    {
        return Area;
    }
}

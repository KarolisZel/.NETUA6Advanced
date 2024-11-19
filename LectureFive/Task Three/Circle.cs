namespace LectureFive.Task_Three;

public class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    protected sealed override double CalculateArea()
    {
        return Math.Round(Math.PI * (Radius * Radius), 2);
    }
}
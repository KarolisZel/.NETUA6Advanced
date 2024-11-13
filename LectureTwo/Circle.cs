namespace LectureTwo;

class Circle
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public double CalculateArea()
    {
        return Math.Round(Math.PI * (Radius * Radius), 3);
    }

    public double CalculatePerimeter()
    {
        return Math.Round(Math.PI * Radius * 2, 3);
    }
}
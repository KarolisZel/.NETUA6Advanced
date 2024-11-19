namespace LectureFour;

public class Triangle : GeometricShapes
{
    public double SideA { get; set; }
    public double SideB { get; set; }
    public double Height { get; set; }

    public Triangle(double sideA, double sideB, double bottomSide, double height)
        : base(bottomSide)
    {
        SideA = sideA;
        SideB = sideB;
        Height = height;
    }

    public override double GetArea()
    {
        return BottomSide * Height / 2;
    }

    public override double GetPerimeter()
    {
        return SideA + SideB + BottomSide;
    }
}
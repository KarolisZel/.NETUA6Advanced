namespace LectureFour;

public abstract class GeometricShapes(double bottomSide)
{
    public double BottomSide { get; set; } = bottomSide;

    public abstract double GetArea();

    public abstract double GetPerimeter();
}
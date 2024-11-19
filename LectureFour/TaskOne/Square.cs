namespace LectureFour;

public class Square(double bottomSide) : GeometricShapes(bottomSide)
{
    public override double GetArea()
    {
        return BottomSide * BottomSide;
    }

    public override double GetPerimeter()
    {
        return 4 * BottomSide;
    }
}
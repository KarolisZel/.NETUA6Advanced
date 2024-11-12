namespace LectureOne;

class Triangle
{
    public double SideA { get; set; }
    public double SideB { get; set; }
    public double SideC { get; set; }
    public double Height { get; set; }

    public Triangle() { }

    public Triangle(double sideA, double sideB, double sideC, double height)
    {
        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
        Height = height;
    }
}
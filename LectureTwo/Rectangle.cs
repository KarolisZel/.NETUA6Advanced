namespace LectureTwo;

class Rectangle
{
    public double Height { get; set; }
    public double Width { get; set; }

    public Rectangle(double height, double width)
    {
        Height = height;
        Width = width;
    }

    public double CalculateArea()
    {
        return Height * Width;
    }

    public double CalculatePerimeter()
    {
        return 2 * (Height + Width);
    }
}

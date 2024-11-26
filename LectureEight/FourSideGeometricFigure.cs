namespace LectureEight;

public class FourSideGeometricFigure
{
    private string Name { get; set; }
    private double Base { get; set; }
    private double Height { get; set; }

    public FourSideGeometricFigure(string name, double @base, double height)
    {
        Name = name;
        Base = @base;
        Height = height;
    }

    public string GetArea()
    {
        return $"Area of a {Name} => {Base * Height}";
    }

    public override string ToString()
    {
        var obj = $"Figure => {Name}\n{GetArea()}\nWith base => {Base} & height {Height}\n";
        return obj;
    }
}
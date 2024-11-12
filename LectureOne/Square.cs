namespace LectureOne;

class Square
{
    public double Side { get; set; }
    public double Diagonal { get; set; }

    public Square() { }

    public Square(double side, double diagonal)
    {
        Side = side;
        Diagonal = diagonal;
    }
}

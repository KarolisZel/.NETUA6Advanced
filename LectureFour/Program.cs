namespace LectureFour;

class Program
{
    static void Main(string[] args)
    {
        ShapesToList();
    }

    private static void ShapesToList()
    {
        var shapes = new List<GeometricShapes>();

        for (int i = 1; i < 6; i++)
        {
            var triangle = new Triangle(i * 1.12, i * 1.24, i * 1.3, i * 1.5);
            shapes.Add(triangle);
        }

        for (int i = 1; i < 6; i++)
        {
            var square = new Square(i * 1.5);
            shapes.Add(square);
        }

        foreach (var shape in shapes)
        {
            Console.WriteLine($"Area => {Math.Round(shape.GetArea(), 3)}");
            Console.WriteLine($"Perimeter => {Math.Round(shape.GetPerimeter(), 3)}\n");
        }
    }
}

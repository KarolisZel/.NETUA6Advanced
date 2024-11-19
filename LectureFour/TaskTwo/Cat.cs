namespace LectureFour;

public class Cat : Animal
{
    public Cat(string name, double weight)
        : base(name, weight) { }

    public override void MakeNoise()
    {
        Console.WriteLine("Meow, Meow!");
    }
}
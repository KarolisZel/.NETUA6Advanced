namespace LectureFour;

public class Dog : Animal
{
    public Dog(string name, double weight)
        : base(name, weight) { }

    public override void MakeNoise()
    {
        Console.WriteLine("Woof, Woof!");
    }
}
namespace LectureFive.Task_Three;

public class Dog : Animal
{
    public Dog(string sound)
        : base(sound) { }

    protected sealed override void MakeSound()
    {
        Console.WriteLine(Sound);
    }
}
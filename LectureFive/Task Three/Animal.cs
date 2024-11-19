namespace LectureFive.Task_Three;

public class Animal
{
    public string Sound { get; set; }

    public Animal(string sound)
    {
        Sound = sound;
    }

    protected virtual void MakeSound()
    {
        Console.WriteLine(Sound);
    }
}
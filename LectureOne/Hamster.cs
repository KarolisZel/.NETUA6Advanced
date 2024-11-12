namespace LectureOne;

class Hamster
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Breed { get; set; }

    public Hamster() { }

    public Hamster(string name, int age, string breed)
    {
        Name = name;
        Age = age;
        Breed = breed;
    }
}

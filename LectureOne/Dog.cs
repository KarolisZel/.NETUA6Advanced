namespace LectureOne;

class Dog
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Breed { get; set; }

    public Dog() { }

    public Dog(string name, int age, string breed)
    {
        Name = name;
        Age = age;
        Breed = breed;
    }
}

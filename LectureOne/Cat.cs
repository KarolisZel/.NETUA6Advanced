namespace LectureOne;

class Cat
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Breed { get; set; }

    public Cat() { }

    public Cat(string name, int age, string breed)
    {
        Name = name;
        Age = age;
        Breed = breed;
    }
}

namespace LectureOne;

class Person
{
    public string Name { get; private set; }
    public int Age { get; private set; }
    public double Height { get; private set; }

    public Adress Adress { get; set; }

    public Person() { }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public Person(string name, int age, double height)
        : this(name, age)
    {
        Height = height;
    }
}

class Adress
{
    public string City { get; set; }
    public string Street { get; set; }
}

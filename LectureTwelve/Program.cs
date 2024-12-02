using static LectureTwelve.Delegates;

namespace LectureTwelve;

class Program
{
    static void Main(string[] args)
    {
        // PersonData personData = delegate(string firstName, string lastName, int age)
        // {
        //     return $"{firstName} {lastName} => {age}";
        // };
        //
        // Console.WriteLine(personData("Kor", "Ral", 20));
        //
        // NumberData numberData = delegate(int number1, int number2)
        // {
        //     return number1 + number2;
        // };
        //
        // Console.WriteLine(numberData(3, 5));
        //
        // ListStep listStep = delegate(List<int> list, int step)
        // {
        //     var result = new List<int>();
        //
        //     var capacity = list.Count;
        //
        //     for (int i = 0; i < capacity; i += step)
        //     {
        //         if (i > capacity)
        //             return result;
        //
        //         result.Add(list[i]);
        //     }
        //
        //     return result;
        // };
        //
        // TypeData<object> typeData = delegate(object element)
        // {
        //     return element.GetType().Name;
        // };
        //
        // Console.WriteLine(typeData(3));

        Console.WriteLine("\n\n");

        List<Person> personList =
        [
            new Person("Joe", 6),
            new Person("Alex", 64),
            new Person("Ashley", 18),
            new Person("Nora", 70),
            new Person("Maximof", 24),
            new Person("Melania", 35),
        ];

        DisplayPeople("Children:", personList, IsChild);
        DisplayPeople("Adults:", personList, IsAdult);
        DisplayPeople("Seniors:", personList, IsSenior);
    }

    private static void DisplayPeople(string title, List<Person> persons, Filter filter)
    {
        Console.WriteLine(title);
        foreach (var person in persons)
        {
            if (filter(person))
            {
                Console.WriteLine($"- {person.Name}, {person.Age} years old");
            }
        }

        Console.WriteLine();
    }

    private static bool IsChild(Person person)
    {
        return person.Age < 18;
    }

    private static bool IsAdult(Person person)
    {
        return person.Age is >= 18 and < 65;
    }

    private static bool IsSenior(Person person)
    {
        return person.Age >= 65;
    }
}

class Delegates
{
    public delegate string PersonData(string fistName, string lastName, int age);

    public delegate int NumberData(int number1, int number2);

    public delegate List<int> ListStep(List<int> list, int step);

    public delegate string TypeData<T>(T element);

    public delegate bool Filter(Person person);
}

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}

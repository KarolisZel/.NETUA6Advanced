namespace LectureOne;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        var person = new Person("Karolis", 26, 1.70);
        Console.WriteLine($"Name: {person.Name}, Age: {person.Age}, Height: {person.Height}\n\n");

        var school = new School("Nemuno", "Kaunas", 170);
        Console.WriteLine(
            $"School: {school.Name}, City: {school.City}, Student count: {school.StudentCount}\n\n"
        );

        var book = new Book();
        var bookList = new List<Book>();
        var bookListByAuthor = GetBooksByAuthor(bookList, "Autorius");

        var products = new List<string> { "Milk", "Bread", "Meat" };
        var store1 = new Store("First", 1999, products);
        var store2 = new Store("Second", 2000, products);

        foreach (var store1Sellable in store1.Sellables)
            Console.WriteLine($"{store1.Name} {store1.YearOpened} - {store1Sellable}");
        Console.WriteLine();
        foreach (var store2Sellable in store2.Sellables)
            Console.WriteLine($"{store2.Name} {store2.YearOpened} - {store2Sellable}");
        Console.WriteLine("\n\n");

        var dog = new Dog();
        var cat = new Cat();
        var hamster = new Hamster();

        var triangle = new Triangle(5.2, 2.4, 3.3, 2.5);
        var square = new Square(2, 2.8);
        var circle = new Circle(2.43);

        var triangleArea = GetTriangleArea(triangle);
        var trianglePerimeter = GetTrianglePerimeter(triangle);

        var squareArea = GetSquareArea(square);
        var sqarePerimeter = GetSquarePerimeter(square);

        var circleArea = GetCircleArea(circle);
        var circlePerimeter = GetCirclePerimeter(circle);

        var audi = new Car("Audi");
        Console.WriteLine($"Is engine on? {IsEngineOn(audi)}");

        var person1 = new Person();
        Console.WriteLine(
            $"Person: {person1.Name}, {person1.Age}, Adress: {person1.Adress.Street}, {person1.Adress.City}"
        );

        var bank = new Bank("Hansa");
        var accountList = CreateNewAccount(bank, "Bober", 10.5);
    }

    private static List<Account> CreateNewAccount(Bank bank, string accountName, double balance)
    {
        var result = new List<Account>();

        var account = new Account(accountName, balance);
        bank.Account.Add(account);

        return result;
    }

    private static bool IsEngineOn(Car car)
    {
        return car.Engine.IsOn;
    }

    private static double GetTriangleArea(Triangle triangle)
    {
        return (triangle.SideC * triangle.Height) / 2;
    }

    private static double GetTrianglePerimeter(Triangle triangle)
    {
        return triangle.SideA + triangle.SideB + triangle.SideC;
    }

    private static double GetSquareArea(Square square)
    {
        return square.Side * square.Side;
    }

    private static double GetSquarePerimeter(Square square)
    {
        return 4 * square.Side;
    }

    private static double GetCircleArea(Circle circle)
    {
        return Math.Round(Math.PI * (circle.Diameter / 2 * circle.Diameter / 2), 3);
    }

    private static double GetCirclePerimeter(Circle circle)
    {
        return Math.Round(2 * Math.PI * (circle.Diameter / 2), 3);
    }

    public static List<Book> GetBooksByAuthor(List<Book> bookList, string author)
    {
        var result = new List<Book>();

        foreach (var book in bookList)
        {
            if (book.Author == author)
                result.Add(book);
        }

        return result;
    }

    private static List<string> GetAnimalNames(Dog dog, Cat cat, Hamster hamster) // Pagal užduotį, turėtų būti List<Dog>...
    {
        var result = new List<string>();
        // Pagal užduotį, reiktų foreach(var dog in Dogs) => result.Add(dog.Name);

        result.Add(dog.Name);
        result.Add(cat.Name);
        result.Add(hamster.Name);

        return result;
    }

    private static Dictionary<string, int> GetAnimalCount(
        List<Dog> dogs,
        List<Cat> cats,
        List<Hamster> hamsters
    )
    {
        var result = new Dictionary<string, int>()
        {
            { "Dog", 0 },
            { "Cat", 0 },
            { "Hamster", 0 }
        };

        foreach (var dog in dogs)
            result["Dog"]++;

        foreach (var cat in cats)
            result["Cat"]++;

        foreach (var hamster in hamsters)
            result["Hamster"]++;

        return result;
    }
}

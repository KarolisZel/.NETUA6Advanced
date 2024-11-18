namespace LectureThree;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}

class Product
{
    public string Name { get; set; }
    public double Price { get; set; }
}

class Food : Product
{
    public DateOnly ExpirationDate { get; set; }

    public Food(DateOnly expirationDate)
    {
        ExpirationDate = expirationDate;
    }

    public void PrintFood()
    {
        Console.WriteLine($"{Name} => {Price} => {ExpirationDate}");
    }
}

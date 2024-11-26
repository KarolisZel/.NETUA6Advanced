namespace LectureEight;

public class Gens<T1, T2>
{
    private T1 First { get; set; }
    private T2 Second { get; set; }

    public Gens(T1 first, T2 second)
    {
        First = first;
        Second = second;
    }

    public void PrintFirst()
    {
        Console.WriteLine(
            $"First variable is of type {First.GetType().Name}, with value => {First}"
        );
    }

    public void PrintSecond()
    {
        Console.WriteLine(
            $"Second variable is of type {Second.GetType().Name}, with value => {Second}"
        );
    }

    public void SetFirst(T1 input)
    {
        Console.Write($"\nChanging {First}, of type {First.GetType().Name} => ");
        First = input;
        Console.WriteLine($"With {First}, of type {First.GetType().Name}\n");
    }

    public void SetSecond(T2 input)
    {
        Console.Write($"\nChanging {Second}, of type {Second.GetType().Name} => ");
        Second = input;
        Console.WriteLine($"With {Second}, of type {Second.GetType().Name}\n");
    }
}

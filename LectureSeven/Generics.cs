namespace LectureSeven;

internal static class Generics
{
    public static void ShowValues<T1, T2>(T1 item1, T2 item2)
    {
        Console.WriteLine($"Item 1 => {item1} of type {item1.GetType().Name}");
        Console.WriteLine($"Item 2 => {item2} of type {item2.GetType().Name}");
    }
}
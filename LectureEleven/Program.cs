namespace LectureEleven;

class Program
{
    static void Main(string[] args)
    {
        var number = 4;
        var other = 5;
        var word = "Word ";
        var sentence = "This is a sentence!";
        var list = new List<int> { 1, 2, 3, 4, 5 };

        Console.WriteLine($"Is {number} positive => {number.IsPositive()}");
        Console.WriteLine($"Is {number} even => {number.IsEven()}");
        Console.WriteLine($"Is {number} lower than {other} => {number.IsLower(other)}");
        Console.WriteLine($"Does sentence contain any spaces => {sentence.HasSpaces()}");

        Console.WriteLine("\n\n");

        Console.WriteLine(word.MakeEmail(1910, "gmail"));
        Console.WriteLine(list.FindAndReturnIfEqual(5));

        var everyOther = list.EveryOtherWord();
        Console.WriteLine($"Every other =>");
        foreach (var t in everyOther)
            Console.Write($"{t} ");
        Console.WriteLine("\n\n");
    }
}

static class MyExtensions
{
    public static bool IsPositive(this int input)
    {
        return input >= 0;
    }

    public static bool IsEven(this int input)
    {
        return input % 2 == 0;
    }

    public static bool IsLower(this int input, int other)
    {
        return input < other;
    }

    public static bool HasSpaces(this string input)
    {
        return input.Trim().Contains(' ');
    }

    public static string MakeEmail(this string fullName, int yearOfBirth, string domain)
    {
        return fullName.Trim().ToLower() + yearOfBirth + "@" + domain.ToLower() + ".com";
    }

    public static T FindAndReturnIfEqual<T>(this List<T> list, T param)
    {
        foreach (var item in list)
        {
            if (item.Equals(param))
                return item;
        }

        Console.WriteLine("Could not find a match!");
        return default;
    }

    public static List<T> EveryOtherWord<T>(this List<T> list)
    {
        List<T> result = new();

        for (int i = 0; i < list.Count; i++)
        {
            if (i % 2 != 0)
                result.Add(list[i]);
        }

        return result;
    }
}

namespace LectureNine;

class Program
{
    static void Main(string[] args)
    {
        var listString = new List<string> { "Low", "Key", "Key", "Match" };
        var listInt = new List<int> { 1, 2, 2, 3 };
        var genString = new GenericBase<string>(listString);
        var genInt = new GenericBase<int>(listInt);

        genInt.PrintList();

        Console.WriteLine("\n");

        var listArray = genInt.ConvertToArray();
        foreach (var i in listArray)
            Console.WriteLine(i);

        Console.WriteLine("\n");

        var matchString = genString.FindOnlyMatch("low");
        var matchInt = genInt.FindOnlyMatch(5);
        Console.WriteLine($"Match found: {matchString}");

        Console.WriteLine("\n");

        var exitsString = genString.Exists("Key");
        var exitsInt = genInt.Exists(5);

        Console.WriteLine($"Input exits? {exitsString}");
    }
}

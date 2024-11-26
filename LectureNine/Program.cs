namespace LectureNine;

class Program
{
    static void Main(string[] args)
    {
        /*
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
        
        Console.WriteLine("\n");
        */

        /*
        var listString = new GenericTwo<string>();
        var listInt = new GenericTwo<int>();

        var addStrings = new List<string> { "My", "Name", "Is", "Kevin" };
        var addInts = new List<int> { 2, 2, 3, 4, 1, 5, 4, };

        listString.PrintList();
        Console.WriteLine("\n");

        listString.Add("Name");
        listInt.Add(6);

        listString.PrintList();
        Console.WriteLine("\n");

        listString.AddMany(addStrings);
        listInt.AddMany(addInts);

        listString.PrintList();
        Console.WriteLine("\n");

        listString.Remove("Name");
        // listString.RemoveIndex(0);
        listInt.Remove(2);
        listString.PrintList();
        */
    }
}

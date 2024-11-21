namespace LectureSeven;

class Program
{
    static void Main(string[] args)
    {
        var list = new MySelfMadeList<int>();

        list.AddElement(3);
        list.AddElement(2);
        list.AddElement(15);
        list.AddElement(0);
        list.AddElement(10);
        list.AddElement(18);

        Console.WriteLine("After adding elements:");
        for (int i = 0; i < list.MyArray.Length; i++)
        {
            Console.WriteLine($"{i} => {list.MyArray[i]}");
        }

        Console.WriteLine();

        list.RemoveElement(3);

        Console.WriteLine("After removing elements:");
        for (int i = 0; i < list.MyArray.Length; i++)
        {
            Console.WriteLine($"{i} => {list.MyArray[i]}");
        }
    }
}

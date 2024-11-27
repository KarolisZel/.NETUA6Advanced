namespace LectureTen;

class GFG
{
    public static void Print()
    {
        int[] arr = { 1, 2, 3, 4, 5 };

        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }

        try
        {
            Console.WriteLine(arr[7]);
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine($"Index is too big, max index is {arr.Length - 1}");
        }
    }
}
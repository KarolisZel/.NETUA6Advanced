namespace LectureNine;

public class GenericTwo<T>
{
    public List<T> List { get; set; }

    public GenericTwo()
    {
        List = new List<T>();
    }

    public void PrintList()
    {
        if (List.Count < 1)
            Console.WriteLine("Add something to the list first!!");

        foreach (var item in List)
        {
            Console.WriteLine(item);
        }
    }

    public T[] ConvertToArray()
    {
        if (List.Count < 1)
            throw new Exception("Add something to the list first!!");

        return List.ToArray();
    }

    public void Add(T input)
    {
        if (IsNull(input))
            throw new Exception("Input is NULL (Errors might occur)");

        List.Add(input);
    }

    public void AddMany(List<T> input)
    {
        if (input.Count < 1)
            throw new Exception("Input is empty!!");

        foreach (var item in input)
        {
            List.Add(item);
        }
    }

    public void Remove(T input)
    {
        if (IsNull(input))
            throw new Exception("Input is NULL (Errors might occur)");

        List.Remove(input);
    }

    public void RemoveIndex(int index)
    {
        if (List.Count < index + 1)
            throw new Exception($"Input index is too big, List only has {List.Count} members!!");

        List.RemoveAt(index);
    }

    public void RemoveAll(T input)
    {
        if (IsNull(input))
            throw new Exception("Input is NULL (Errors might occur)");

        List.RemoveAll(i => i.Equals(input));
    }

    private bool IsNull(T input)
    {
        return input is null;
    }
}

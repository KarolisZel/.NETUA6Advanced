using System.ComponentModel;

namespace LectureNine;

public class GenericBase<T>
{
    public List<T> List { get; }

    public GenericBase(List<T> list)
    {
        List = list;
    }

    public void PrintList()
    {
        foreach (var item in List)
        {
            Console.WriteLine(item);
        }
    }

    public T[] ConvertToArray()
    {
        return List.ToArray();
    }

    public T FindOnlyMatch(T input)
    {
        var result = default(T);
        var count = 0;

        if (IsNull(input))
            throw new Exception("Cannot look for matches to NULL");

        foreach (var item in List)
        {
            if (item.Equals(input) && count < 2)
            {
                count++;
                result = item;
            }
        }

        if (count > 1)
            throw new Exception("More than one matches found!");

        if (count is 0)
            return default;

        return result;
    }

    public bool Exists(T input)
    {
        if (IsNull(input))
            throw new Exception("Input is NULL");

        if (List.Contains(input))
            return true;

        return false;
    }

    private bool IsNull(T input)
    {
        return input is null;
    }
}

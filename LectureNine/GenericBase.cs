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

        if (input is null)
            throw new NullReferenceException("Cannot look for matches to null");

        foreach (var item in List)
        {
            if (item.Equals(input) && count < 2)
            {
                count++;
                result = item;
            }
        }

        if (count > 1)
            throw new WarningException("More than one matches found!");

        if (count is 0)
            return default;

        return result;
    }

    public bool Exists(T input)
    {
        if (input is null)
            throw new NullReferenceException("Cannot look for matches to null");

        if (List.Contains(input))
            return true;

        return false;
    }
}
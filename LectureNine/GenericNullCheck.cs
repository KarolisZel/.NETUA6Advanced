namespace LectureNine;

public class GenericNullCheck<T>
{
    public bool IsNull(T input)
    {
        return input is null;
    }
}
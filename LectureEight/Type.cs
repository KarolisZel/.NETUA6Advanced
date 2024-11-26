namespace LectureEight;

public class Type<T1, T2>
{
    public T1 Type1 { get; set; }
    public T2 Type2 { get; set; }

    public Type(T1 type1, T2 type2)
    {
        Type1 = type1;
        Type2 = type2;
    }

    public string GetType<T>(T input)
    {
        return input.GetType().Name;
    }
}
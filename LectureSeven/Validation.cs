namespace LectureSeven;

internal static class Validation
{
    public static bool Validate<T>(T item)
    {
        if (item is null)
        {
            throw new ArgumentNullException($"Given parameter is null");
        }

        return true;
    }
}
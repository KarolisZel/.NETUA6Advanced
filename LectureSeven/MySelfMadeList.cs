namespace LectureSeven;

public class MySelfMadeList<T>
{
    public T[] MyArray { get; set; }
    private int Index = 0;
    private int Size = 1;

    public MySelfMadeList()
    {
        MyArray = new T[Size];
    }

    public void AddElement(T elementToAdd)
    {
        if (CheckIfNull())
            MyArray = IncreaseListSize();

        if (elementToAdd is not null)
        {
            MyArray[Index] = elementToAdd;
            Index++;
        }
        else
        {
            throw new ArgumentNullException(nameof(elementToAdd));
        }
    }

    public void RemoveElement(T elementToRemove)
    {
        if (elementToRemove is not null)
        {
            var i = Array.IndexOf(MyArray, elementToRemove);

            if (i < 0)
                return;

            MyArray = DecreaseListSize(i);
            Index--;
        }
        else
        {
            throw new ArgumentNullException(nameof(elementToRemove));
        }
    }

    private T[] IncreaseListSize()
    {
        Size += 1;
        var newArray = new T[Size];
        MyArray.CopyTo(newArray, 0);
        return newArray;
    }

    private T[] DecreaseListSize(int i)
    {
        Size -= 1;
        var newArray = new T[Size];
        for (int j = 0; j < newArray.Length; j++)
        {
            if (j < i)
                newArray[j] = MyArray[j];
            else
                newArray[j] = MyArray[j + 1];
        }
        return newArray;
    }

    private bool CheckIfNull()
    {
        return Index == Size;
    }
}

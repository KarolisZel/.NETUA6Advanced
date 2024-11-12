namespace LectureOne;

class Store
{
    public string Name { get; private set; }
    public int YearOpened { get; private set; }
    public List<string> Sellables { get; private set; }

    public Store() { }

    public Store(string name, int yearOpened, List<string> sellables)
    {
        Name = name;
        YearOpened = yearOpened;
        Sellables = sellables;
    }
}
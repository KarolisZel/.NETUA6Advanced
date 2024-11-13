namespace LectureTwo;

class Number
{
    public List<int> Numbers { get; set; }

    public Number(List<int> numbers)
    {
        Numbers = numbers;
    }

    public void AddNumber(int number)
    {
        Numbers.Add(number);
    }

    public void PrintNumberList()
    {
        foreach (var number in Numbers)
        {
            Console.WriteLine(number);
        }
    }
}

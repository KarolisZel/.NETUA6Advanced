namespace LectureThree;

class Electronic : Product
{
    public int Warranty { get; set; }

    public Electronic(int warranty)
    {
        Warranty = warranty;
    }

    public void PrintElectronic()
    {
        Console.WriteLine($"{Name} => {Price} => {Warranty}");
    }
}

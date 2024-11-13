namespace LectureTwo;

class Computer
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Ram { get; set; }
    public int Storage { get; set; }

    public Computer(string brand, string model, int ram, int storage)
    {
        Brand = brand;
        Model = model;
        Ram = ram;
        Storage = storage;
    }

    public bool IsEnoughRam(int recommendedRam)
    {
        if (Ram >= recommendedRam)
            return true;

        return false;
    }
}
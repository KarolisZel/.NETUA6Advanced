namespace LectureFour;

public class Bike : Vehicle
{
    public bool IsHelmetRequired { get; set; }

    public Bike(int wheelCount, int doorCount, int maxSpeed, bool isHelmetRequired)
        : base(wheelCount, doorCount, maxSpeed)
    {
        IsHelmetRequired = isHelmetRequired;
    }
}
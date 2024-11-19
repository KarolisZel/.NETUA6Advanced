namespace LectureFour;

public abstract class Vehicle
{
    public int WheelCount { get; set; }
    public int DoorCount { get; set; }
    public int MaxSpeed { get; set; }

    public Vehicle(int wheelCount, int doorCount, int maxSpeed)
    {
        WheelCount = wheelCount;
        DoorCount = doorCount;
        MaxSpeed = maxSpeed;
    }
}

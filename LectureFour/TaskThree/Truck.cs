namespace LectureFour;

public class Truck : Vehicle
{
    public double CargoSpace { get; set; }

    public Truck(int wheelCount, int doorCount, int maxSpeed, double cargoSpace)
        : base(wheelCount, doorCount, maxSpeed)
    {
        CargoSpace = cargoSpace;
    }
}
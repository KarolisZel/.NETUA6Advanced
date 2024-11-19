namespace LectureFour;

public abstract class Human
{
    public string Name { get; set; }
    public int Age { get; set; }

    public List<Vehicle> Vehicles { get; set; }

    public Human(string name, int age)
    {
        Name = name;
        Age = age;
        Vehicles = new List<Vehicle>();
    }

    public List<Vehicle> AddVehicle(Vehicle vehicle)
    {
        Vehicles.Add(vehicle);
        return Vehicles;
    }
}
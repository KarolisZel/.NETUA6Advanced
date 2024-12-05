namespace LectureFourteen;

public abstract class Car(string model, int fuel) : IVehicle
{
    public string Model { get; set; } = model;
    private int Fuel { get; set; } = fuel;

    public bool Drive(bool isDriving)
    {
        if (isDriving)
        {
            Console.WriteLine($"You are already driving your {Model}");
            return true;
        }

        if (Fuel > 0 && !isDriving)
        {
            Console.WriteLine($"You start driving your {Model}");
            return true;
        }

        Console.WriteLine($"Your {Model} is asking for some juice (Refuel)");
        return false;
    }

    public void Refuel(int fuelAmount)
    {
        const int maxFuel = 70;
        Console.WriteLine("You start refueling your car...");
        Console.WriteLine("This will only take a few moments...\n");

        if (fuelAmount < 0)
        {
            Console.WriteLine($"You have entered an invalid amount => {fuelAmount}\n");
            return;
        }
        if (Fuel + fuelAmount > maxFuel)
        {
            Console.WriteLine($"Filled up by {maxFuel - Fuel}L.");
            Fuel = maxFuel;
            Console.WriteLine($"Your tank is fully fueled!\n");
        }
        if (Fuel + fuelAmount <= maxFuel)
        {
            Fuel += fuelAmount;
            Console.WriteLine($"Filled up by {fuelAmount}L. Tank is at {Fuel}L.\n");
        }
    }
}

public class BmwCar(bool isXDrive, string model, int fuel) : Car(model, fuel)
{
    public bool IsXDrive { get; set; }
}

public class AudiCar(bool isQuattro, string model, int fuel) : Car(model, fuel)
{
    public bool IsQuattro { get; set; }
}

namespace LectureFour;

public class Bus : Vehicle
{
    public int PassengerSeatCount { get; set; }

    public Bus(int wheelCount, int doorCount, int maxSpeed, int passengerSeatCount)
        : base(wheelCount, doorCount, maxSpeed)
    {
        PassengerSeatCount = passengerSeatCount;
    }
}

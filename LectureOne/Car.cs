namespace LectureOne;

class Car
{
    public string Model { get; set; }
    public Engine Engine { get; set; }

    public Car(string model)
    {
        Model = model;
    }

    public void StartStopEngine()
    {
        Engine.IsOn = !Engine.IsOn;
    }
}

class Engine
{
    public bool IsOn { get; set; }
}

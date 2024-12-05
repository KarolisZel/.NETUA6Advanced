namespace LectureFourteen;

class Program
{
    static void Main(string[] args)
    {
        // var audi = new AudiCar(false, "Audi", 20);
        // var bmw = new BmwCar(true, "Bmw", 100);
        // var isAudiDriving = false;
        // audi.Refuel(60);
        // isAudiDriving = audi.Drive(isAudiDriving);
        // //stop
        // isAudiDriving = false;
        //
        // Console.WriteLine(audi.Model);

        var audiList = new List<AudiCar>
        {
            new AudiCar(true, "RS7", 50),
            new AudiCar(true, "RS8", 50),
            new AudiCar(true, "RS6", 50),
        };
        var audiComparer = new AudiCarComparer();

        audiList.Sort(audiComparer);
    }
}

public class AudiCarComparer : IComparer<AudiCar>
{
    public int Compare(AudiCar? x, AudiCar? y)
    {
        return string.Compare(x.Model, y.Model);
    }
}

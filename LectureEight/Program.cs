namespace LectureEight;

class Program
{
    static void Main(string[] args)
    {
        // var gens = new Gens<int, string>(2, "2");
        //
        // gens.PrintFirst();
        // gens.SetFirst(0);
        // gens.PrintFirst();
        //
        // Console.WriteLine("\n");
        //
        // gens.PrintSecond();
        // gens.SetSecond("3");
        // gens.PrintSecond();
        //
        // Console.WriteLine("\n\n");
        //
        // var fig = new FourSideGeometricFigure("Rectangle", 1.25, 1.5);
        //
        // Generator<FourSideGeometricFigure>.Show(fig);
        //
        // Console.WriteLine("\n\n");
        //
        // var typ = new Type<int, string>(1, "2");
        //
        // Console.WriteLine($"Type => {typ.GetType(1.35)}");
        //
        // Console.WriteLine("\n\n");
    }
}

public class SportLeague<T>
{
    private List<T> teams;

    public SportLeague()
    {
        teams = new List<T>();
    }

    public void AddTeam(T team)
    {
        if (team == null)
        {
            throw new ArgumentNullException(nameof(team), "Team cannot be null.");
        }

        if (teams.Count > 0 && team.GetType() != teams[0].GetType())
        {
            throw new InvalidOperationException(
                $"Cannot add a team of type {team.GetType().Name} to a league of {teams[0].GetType().Name}."
            );
        }

        teams.Add(team);
    }

    public void PrintTeams()
    {
        if (teams.Count == 0)
        {
            Console.WriteLine("No teams in the league.");
            return;
        }

        Console.WriteLine($"Teams in the {typeof(T).Name} League:");
        foreach (var team in teams)
        {
            Console.WriteLine($"- {team}");
        }
    }
}

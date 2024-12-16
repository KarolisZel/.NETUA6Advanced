namespace LectureSixteen;

class Program
{
    static async Task Main(string[] args)
    {
        var path = @"C:\Users\koral\OneDrive\Stalinis kompiuteris";
        var pb = new ProgressBar();
        var pbTask = IncreaseProgress(pb);
        var desktop = GetDesktop(path);

        Console.WriteLine("Loading world...");
        Console.WriteLine($"Current progress => {pb.Progress}");

        while (!pbTask.IsCompleted)
        {
            var pbCurr = await GetProgress(pb);

            Console.Clear();
            Console.WriteLine("Loading world...");
            Console.WriteLine($"Current progress => {pbCurr}\n\n");

            Console.WriteLine("Current Desktop:");
            Console.WriteLine("\t" + string.Join(",\n\t", desktop.Result));
        }

        Console.Clear();
        Console.WriteLine("Hello, World!");
    }

    private static async Task<ProgressBar> IncreaseProgress(ProgressBar pb)
    {
        for (int i = 0; i < 101; i++)
        {
            await Task.Delay(1000);
            pb.Progress++;
        }

        return pb;
    }

    private static async Task<int> GetProgress(ProgressBar pb)
    {
        await Task.Delay(3000);

        return pb.Progress;
    }

    private static async Task<string[]> GetDesktop(string path)
    {
        await Task.Delay(5000);
        var desktop = Directory.GetFiles(path);

        return desktop;
    }
}

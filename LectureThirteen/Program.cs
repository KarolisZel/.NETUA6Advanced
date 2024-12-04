namespace LectureThirteen;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!\n");

        //     List<int> numbers = [1, -2, -3, 4, -5, 6, -7, 8, 9, 10, -11, -12];
        //
        //     var sqrNumbers = numbers.Select(x => Math.Pow(x, 2)).ToList();
        //
        //     var posNumbers = numbers.Where(x => x > 0).ToList();
        //
        //     var pos10Numbers = numbers.Where(x => x > 0 && x < 10).ToList();
        //
        //     var numbersAscending = numbers.Order().ToList();
        //     var numbersDecending = numbers.OrderDescending().ToList();
        //
        //     var maxNumber = numbers.Max();

        var dirPath = @"C:\Users\koral\downloads";
        var fileNames = new List<string>();
        var fileExtensions = new List<string>();
        try
        {
            fileNames.AddRange(Directory.GetFiles(dirPath).Select(Path.GetFileName));
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }

        foreach (var file in fileNames)
        {
            var extension = Path.GetExtension(file);
            if (!string.IsNullOrEmpty(extension))
                fileExtensions.Add(extension);
        }

        var txtFiles = fileExtensions.Where(x => x == ".pdf").ToList();
        var fullTxtFiles = fileNames.Where(x => x.EndsWith(".pdf")).ToList();
    }
}

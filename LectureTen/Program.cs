namespace LectureTen;

class Program
{
    static void Main(string[] args)
    {
        // string[] values =
        // {
        //     "-1,035.77219",
        //     "1AFF",
        //     "1e-35",
        //     "1,635,592,999,999,999,999,999,999",
        //     "-17.455",
        //     "190.34001",
        //     "1.29e325"
        // };
        //
        // GFG.Print();
        //
        // foreach (var str in values)
        // {
        //     var doub = ConvertStringToDouble(str);
        // }
        //
        // Console.WriteLine("\n\n");
        //
        // int[] arr = { 19, 0, 75, 52 };
        //
        // for (int i = 0; i < arr.Length; i++)
        // {
        //     try
        //     {
        //         Console.WriteLine(arr[i] / arr[i + 1]);
        //     }
        //     catch (DivideByZeroException e)
        //     {
        //         Console.WriteLine($"Cannot divide by zero => {e.Message}");
        //     }
        //     catch (IndexOutOfRangeException e)
        //     {
        //         Console.WriteLine($"Cannot execute last operation => {e.Message}");
        //     }
        // }
        //
        // Console.WriteLine("\n\n");

        FileReader fileReader = new FileReader();

        string content = fileReader.ReadFile(
            @"C:\Users\koral\RiderProjects\LearningOOP\LectureTen\Test.txt"
        );

        if (!string.IsNullOrEmpty(content))
        {
            Console.WriteLine("File contains:");
            Console.WriteLine(content);
        }
        else
        {
            Console.WriteLine("Could not read file");
        }
    }

    private static double ConvertStringToDouble(string value)
    {
        double result;
        try
        {
            result = Convert.ToDouble(value);
            Console.WriteLine("Converted '{0}' to {1}.", value, result);
            return result;
        }
        catch (FormatException)
        {
            Console.WriteLine("Unable to convert '{0}' to a Double.", value);
        }
        catch (OverflowException)
        {
            Console.WriteLine("'{0}' is outside the range of a Double.", value);
        }

        return 0;
    }
}

public class FileReader
{
    public string ReadFile(string filePath)
    {
        try
        {
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException("File not found", filePath);
            }

            return File.ReadAllText(filePath);
        }
        catch (FileNotFoundException e)
        {
            Console.WriteLine($"File error => {e.Message}");
        }
        catch (UnauthorizedAccessException e)
        {
            Console.WriteLine($"Authorization error => {e.Message}");
        }
        catch (IOException e)
        {
            Console.WriteLine($"I/O error => {e.Message}");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Other error => {e.Message}");
        }

        return string.Empty;
    }
}

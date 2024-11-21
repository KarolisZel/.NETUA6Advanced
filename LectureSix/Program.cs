using System.Text;

namespace LectureSix;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine();

        var filePath = @"C:\Users\koral\RiderProjects\LearningOOP\LectureSix\Files\File.txt";
        var writePath = @"C:\Users\koral\RiderProjects\LearningOOP\LectureSix\Files\NewFile1.txt";
        var path = @"C:\Users\koral\RiderProjects\LearningOOP\LectureSix\Files";

        var allText = File.ReadAllText(filePath);
        Console.WriteLine(allText);

        var text = new List<string>() { "Hello, it's me!" };

        File.WriteAllLines(writePath, text);

        // File.Copy(filePath, path + @"\Copied.txt");

        //------------------------------------------------------------------------------------------------------------//

        var readText = File.ReadLines(filePath);

        foreach (var line in readText)
            Console.WriteLine($" => {line.Length}");

        using (var writer = new StreamWriter(path + @"\Stream.txt"))
        {
            writer.WriteLine("line");
            writer.WriteLine(213);
            writer.WriteLine(213.23);
        }

        using (
            var writer = new BinaryWriter(
                File.Open(path + @"\Binary.bin", FileMode.Create, FileAccess.Write)
            )
        )
        {
            writer.Write(1225);
            writer.Write("1225");
            writer.Write(1225.422);
        }

        using (var reader = new BinaryReader(File.Open(path + @"\Binary.bin", FileMode.Open)))
        {
            var number = reader.ReadInt32();
            var message = reader.ReadString();
            var pi = reader.ReadDouble();

            Console.WriteLine($"Read int: {number}");
            Console.WriteLine($"Read double: {pi}");
            Console.WriteLine($"Read string: {message}");
        }

        //------------------------------------------------------------------------------------------------------------//

        using (var fs = new FileStream(path + @"\PartThree.txt", FileMode.Create, FileAccess.Write))
        {
            using (var writer = new StreamWriter(fs, Encoding.UTF8, 8192))
            {
                for (var i = 0; i < 1000; i++)
                {
                    writer.WriteLine($"This is line {i + 1}");
                }
            }
        }
    }
}

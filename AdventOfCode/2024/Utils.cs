namespace AdventOfCode._2024;

public static class Utils
{
    public static string[] GetLinesFromFile(string filename)
    {
        var sCurrentDirectory = AppDomain.CurrentDomain.BaseDirectory;
        var relativePath = $"2024{Path.DirectorySeparatorChar}Inputs{Path.DirectorySeparatorChar}{filename}";
        string[] lines;
        try
        {
            lines = File.ReadAllLines(Path.Combine(sCurrentDirectory, relativePath));
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return [];
        }

        return lines;
    }
}
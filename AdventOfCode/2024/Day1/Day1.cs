using System.Diagnostics;

namespace AdventOfCode._2024.Day1;

public class Day1
{
    private readonly string _fileContents = Utils.GetFileContentsByName("day1.txt");

    public void PrintPartOneSolution()
    {
        Stopwatch watch = new Stopwatch();
        watch.Start();
        var numbers = _fileContents
            .Split([' ', '\r', '\n'])
            .Where(s => !string.IsNullOrWhiteSpace(s))
            .Select(int.Parse);
        
        var counter = 0;
        var left = new List<int>();
        var right = new List<int>();
        foreach (var number in numbers)
        {
            if (counter % 2 == 0)
                left.Add(number);
            else
                right.Add(number);
            counter++;
        }

        left.Sort();
        right.Sort();
        var sum = 0;
        for (int i = 0; i < left.Count; i++)
        {
            sum += Math.Abs(left[i] - right[i]);
        }

        Console.WriteLine(sum);
        watch.Stop();
        Console.WriteLine($"Elapsed time: {watch.ElapsedMilliseconds}");
    }
}
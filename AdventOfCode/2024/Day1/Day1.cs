using System.Diagnostics;

namespace AdventOfCode._2024.Day1;

public class Day1
{
    private readonly string[] _lines = Utils.GetFileContentsByName("day1.txt");

    public void PrintPartOneSolution()
    {
        var left = new List<int>();
        var right = new List<int>();
        foreach (var line in _lines)
        {
            var l = line.Split();
            left.Add(int.Parse(l[0]));
            right.Add(int.Parse(l[^1]));
        }

        left.Sort();
        right.Sort();
        
        var sum = 0;
        for (int i = 0; i < left.Count; i++)
            sum += Math.Abs(left[i] - right[i]);
        
        Console.WriteLine(sum);
    }
}
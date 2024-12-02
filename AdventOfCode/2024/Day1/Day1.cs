namespace AdventOfCode._2024.Day1;

public class Day1
{
    private readonly string[] _lines = Utils.GetLinesFromFile("day1.txt");
    private readonly List<int> leftColumn = [];
    private readonly List<int> rightColumn = [];

    public Day1()
    {
        foreach (var line in _lines)
        {
            string[] lineArr = line.Split();
            leftColumn.Add(int.Parse(lineArr[0]));
            rightColumn.Add(int.Parse(lineArr[^1]));
        }
    }

    public void PrintPartOneSolution()
    {
        leftColumn.Sort();
        rightColumn.Sort();

        var locationSum = 0;
        for (var i = 0; i < leftColumn.Count; i++)
            locationSum += Math.Abs(leftColumn[i] - rightColumn[i]);

        Console.WriteLine(locationSum);
    }

    public void PrintPartTwoSolution()
    {
        var result = leftColumn.Sum(number => number * rightColumn.Count(r => r == number));
        Console.WriteLine(result);
    }
}
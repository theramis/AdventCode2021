namespace AdventCode2021.Days._1;

public class Day1Runner : IRunner
{
    private readonly int[] _numbers = File.ReadAllLines("Days/1/Day1RunnerInput.txt").Select(int.Parse).ToArray();

    public void RunPart1()
    {
        var count = _numbers[1..].Select((num, i) => num > _numbers[i]).Count(x => x);
        Console.WriteLine($"Part 1 Answer: {count}");
    }

    public void RunPart2()
    {
        var count = _numbers[3..].Select((num, i) => num > _numbers[i]).Count(x => x);
        Console.WriteLine($"Part 2 Answer: {count}");
    }
}

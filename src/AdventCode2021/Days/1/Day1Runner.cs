namespace AdventCode2021.Days._1;

public class Day1Runner : IRunner
{
    private readonly int[] _numbers = File.ReadAllLines("Days/1/Day1RunnerInput.txt").Select(int.Parse).ToArray();

    public void RunPart1()
    {
        var prev = _numbers[0];
        var count = 0;
        foreach (var number in _numbers[1..])
        {
            if (number > prev)
                count++;

            prev = number;
        }

        Console.WriteLine($"Part 1 Answer: {count}");
    }

    public void RunPart2()
    {
        var prev1 = _numbers[0];
        var prev2 = _numbers[1];
        var prev3 = _numbers[2];

        var count = 0;
        foreach (var number in _numbers[3..])
        {
            var prevSum = prev1 + prev2 + prev3;
            var currentSum = prev2 + prev3 + number;

            if (currentSum > prevSum)
                count++;

            prev1 = prev2;
            prev2 = prev3;
            prev3 = number;
        }

        Console.WriteLine($"Part 2 Answer: {count}");
    }
}

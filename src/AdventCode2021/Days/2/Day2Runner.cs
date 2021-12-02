namespace AdventCode2021.Days._2;

public class Day2Runner : IRunner
{
    private readonly (string, int)[] commands = File.ReadAllLines("Days/2/Day2RunnerInput.txt").Select(l =>
    {
        var command = l.Split(" ");
        return (command[0], int.Parse(command[1]));
    }).ToArray();

    public void RunPart1()
    {
        var horizontalPosition = 0;
        var depth = 0;

        foreach (var (direction, units) in commands)
        {
            switch (direction)
            {
                case "forward":
                    horizontalPosition += units;
                    break;
                case "down":
                    depth += units;
                    break;
                case "up":
                    depth -= units;
                    break;
                default:
                    throw new Exception($"Unknown direction: {direction}");
            }
        }

        Console.WriteLine($"Part 1 Answer: {horizontalPosition * depth}");
    }

    public void RunPart2()
    {
        var horizontalPosition = 0;
        var depth = 0;
        var aim = 0;

        foreach (var (direction, units) in commands)
        {
            switch (direction)
            {
                case "forward":
                    horizontalPosition += units;
                    depth += aim * units;
                    break;
                case "down":
                    aim += units;
                    break;
                case "up":
                    aim -= units;
                    break;
                default:
                    throw new Exception($"Unknown direction: {direction}");
            }
        }

        Console.WriteLine($"Part 2 Answer: {horizontalPosition * depth}");
    }
}

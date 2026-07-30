using PlcTagExplorer.Models;

namespace PlcTagExplorer.Services;

public class StatisticsService
{
    public void Print(
        IEnumerable<PlcTag> tags)
    {
        Console.WriteLine("Statistics");
        Console.WriteLine("----------");

        Console.WriteLine(
            $"Total tags: {tags.Count()}");

        foreach (var group in tags.GroupBy(t => t.Group))
        {
            Console.WriteLine(
                $"{group.Key}: {group.Count()}");
        }
    }
}

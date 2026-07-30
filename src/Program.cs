using PlcTagExplorer.Services;

namespace PlcTagExplorer;

internal class Program
{
    static void Main(string[] args)
    {
        var repository = new TagRepository();
        var search = new SearchService();
        var statistics = new StatisticsService();

        var tags = repository.GetAll();

        Console.WriteLine("PLC Tag Explorer");
        Console.WriteLine("================");
        Console.WriteLine();

        Console.WriteLine($"Loaded tags: {tags.Count}");
        Console.WriteLine();

        var results = search.Find(tags, "Motor");

        foreach (var tag in results)
        {
            Console.WriteLine(
                $"{tag.Name} | {tag.Type} | {tag.Value}"
            );
        }

        Console.WriteLine();
        statistics.Print(tags);
    }
}

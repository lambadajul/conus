using PlcTagExplorer.Models;

namespace PlcTagExplorer.Utils;

public static class ConsoleTable
{
    public static void Print(
        IEnumerable<PlcTag> tags)
    {
        Console.WriteLine();

        Console.WriteLine(
            "Name".PadRight(20) +
            "Type".PadRight(10) +
            "Value".PadRight(12) +
            "Group"
        );

        Console.WriteLine(
            new string('-', 55));

        foreach (var tag in tags)
        {
            Console.WriteLine(
                tag.Name.PadRight(20) +
                tag.Type.ToString().PadRight(10) +
                tag.Value?.ToString()?.PadRight(12) +
                tag.Group
            );
        }
    }
}

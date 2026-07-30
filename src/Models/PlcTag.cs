namespace PlcTagExplorer.Models;

public class PlcTag
{
    public string Name { get; set; } = "";

    public TagType Type { get; set; }

    public object? Value { get; set; }

    public string Address { get; set; } = "";

    public string Group { get; set; } = "";
}

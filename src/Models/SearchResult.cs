namespace PlcTagExplorer.Models;

public class SearchResult
{
    public List<PlcTag> Tags { get; set; } = new();

    public int Total => Tags.Count;

    public DateTime GeneratedAt { get; set; }
        = DateTime.Now;
}

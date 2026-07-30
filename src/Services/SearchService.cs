using PlcTagExplorer.Models;

namespace PlcTagExplorer.Services;

public class SearchService
{
    public List<PlcTag> Find(
        IEnumerable<PlcTag> tags,
        string keyword)
    {
        if (string.IsNullOrWhiteSpace(keyword))
        {
            return tags.ToList();
        }

        return tags
            .Where(t =>
                t.Name.Contains(
                    keyword,
                    StringComparison.OrdinalIgnoreCase))
            .OrderBy(t => t.Name)
            .ToList();
    }
}

using PlcTagExplorer.Models;

namespace PlcTagExplorer.Services;

public class FilterService
{
    public List<PlcTag> ByType(
        IEnumerable<PlcTag> tags,
        TagType type)
    {
        return tags
            .Where(t => t.Type == type)
            .ToList();
    }

    public List<PlcTag> ByGroup(
        IEnumerable<PlcTag> tags,
        string group)
    {
        return tags
            .Where(t =>
                t.Group.Equals(
                    group,
                    StringComparison.OrdinalIgnoreCase))
            .ToList();
    }
}

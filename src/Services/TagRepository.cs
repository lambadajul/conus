using PlcTagExplorer.Data;
using PlcTagExplorer.Models;

namespace PlcTagExplorer.Services;

public class TagRepository
{
    private readonly List<PlcTag> _tags;

    public TagRepository()
    {
        _tags = SampleTags.Items;
    }

    public List<PlcTag> GetAll()
    {
        return _tags;
    }

    public PlcTag? FindByName(string name)
    {
        return _tags.FirstOrDefault(t =>
            t.Name.Equals(
                name,
                StringComparison.OrdinalIgnoreCase
            ));
    }
}

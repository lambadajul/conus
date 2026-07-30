using PlcTagExplorer.Models;
using PlcTagExplorer.Services;
using Xunit;

namespace PlcTagExplorer.Tests;

public class SearchServiceTests
{
    [Fact]
    public void Should_Find_Tag()
    {
        var service = new SearchService();

        var tags = new List<PlcTag>
        {
            new PlcTag
            {
                Name = "MotorSpeed",
                Type = TagType.Real
            }
        };

        var result = service.Find(
            tags,
            "Motor"
        );

        Assert.Single(result);
    }
}

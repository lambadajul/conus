using System.Text;
using PlcTagExplorer.Models;

namespace PlcTagExplorer.Services;

public class CsvExportService
{
    public string Export(
        IEnumerable<PlcTag> tags)
    {
        var builder = new StringBuilder();

        builder.AppendLine(
            "Name,Type,Value,Address,Group");

        foreach (var tag in tags)
        {
            builder.AppendLine(
                $"{tag.Name}," +
                $"{tag.Type}," +
                $"{tag.Value}," +
                $"{tag.Address}," +
                $"{tag.Group}");
        }

        return builder.ToString();
    }
}

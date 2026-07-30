using PlcTagExplorer.Models;

namespace PlcTagExplorer.Data;

public static class SampleTags
{
    public static List<PlcTag> Items => new()
    {
        new PlcTag
        {
            Name = "MotorSpeed",
            Type = TagType.Real,
            Value = 1450.5,
            Address = "DB1.DBW0",
            Group = "Motors"
        },

        new PlcTag
        {
            Name = "MotorRunning",
            Type = TagType.Bool,
            Value = true,
            Address = "M0.0",
            Group = "Motors"
        },

        new PlcTag
        {
            Name = "TankLevel",
            Type = TagType.Real,
            Value = 74.2,
            Address = "DB2.DBW8",
            Group = "Process"
        },

        new PlcTag
        {
            Name = "AlarmCode",
            Type = TagType.Int,
            Value = 0,
            Address = "DB5.DBW2",
            Group = "Alarms"
        }
    };
}

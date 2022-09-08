using ZooTycoon.NET.DataModels.Interfaces;

namespace ZooTycoon.NET.DataModels.Sections.Sounds
{
    public class Sounds : IDataSection
    {
        public Dictionary<string, Sound> Sound { get; set; } = new();
    }
}

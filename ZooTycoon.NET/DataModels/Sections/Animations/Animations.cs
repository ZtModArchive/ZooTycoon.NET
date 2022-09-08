using ZooTycoon.NET.DataModels.Interfaces;

namespace ZooTycoon.NET.DataModels.Sections.Animations
{
    public class Animations : IDataSection
    {
        public Dictionary<string, Animation> Animation { get; set; } = new();
    }
}

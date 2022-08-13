namespace ZooTycoon.NET.DataModels.Classes.Colors
{
    public class Color
    {
        public string Name { get; set; } = string.Empty;
        public int NumColors { get; set; }
        public IEnumerable<string> Palettes { get; set; } = Enumerable.Empty<string>();
    }
}
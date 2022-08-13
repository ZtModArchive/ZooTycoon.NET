namespace ZooTycoon.NET.DataModels.Classes.Colors
{
    public class ColorReplace
    {
        public CRColor CRColor { get; set; } = new CRColor();
        public IEnumerable<Color> Replace { get; set; } = Enumerable.Empty<Color>();
        public int? Title { get; set; }
        public string? DefaultPal { get; set; }
    }
}

using ZooTycoon.NET.DataModels.Enums;

namespace ZooTycoon.NET.DataModels.Sections.Characteristics
{
    public class SceneryCharacteristics : Characteristics
    {
        public int? NameID { get; set; }
        public int? HelpID { get; set; }
        public int? PurchaseCost { get; set; }
        public Habitat Habitat { get; set; }
        public int? FootprintX { get; set; }
        public int? FootprintY { get; set; }
        public int? Height { get; set; }
        public bool? Walkable { get; set; }
    }
}

using ZooTycoon.NET.DataModels.Classes.Text;
using ZooTycoon.NET.DataModels.Enumeration;

namespace ZooTycoon.NET.DataModels.Classes.Characteristics
{
    public abstract class Characteristics
    {
        public TranslatableText Name { get; set; } = new TranslatableText();
        public TranslatableText Help { get; set; } = new TranslatableText();
        public int PurchaseCost { get; set; }
        public int FootPrintX { get; set; }
        public int FootPrintY { get; set; }
        public int Height { get; set; }
        public Habitat Habitat { get; set; } = Habitat.NullHabitat;
        public Location Location { get; set; } = Location.NullLocation;
        public bool Walkable { get; set; }
        public bool Deletable { get; set; }
        public bool Stink { get; set; }
        public bool AutoRotate { get; set; }
        public bool Swims { get; set; }
        public bool OnlySwims { get; set; }
        public bool Underwater { get; set; }
        public bool OnlyUnderwater { get; set; }
    }
}

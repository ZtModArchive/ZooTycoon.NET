using ZooTycoon.NET.DataModels.Sections.Characteristics;
using ZooTycoon.NET.DataModels.SubTypes;

namespace ZooTycoon.NET.Entities.Scenery
{
    public class Scenery : Entity<ScenerySubType, SceneryCharacteristics>
    {
        public Scenery(string type) : this()
        {
            Type = type;
        }

        public Scenery(string type, ScenerySubType subType) : this()
        {
            Type = type;
            SubType = subType;
        }

        public Scenery()
        {
        }

        public Dictionary<GuestSubTypes, int>? EstheticBonus { get; set; }
    }
}

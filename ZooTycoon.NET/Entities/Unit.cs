using ZooTycoon.NET.DataModels.Sections.Characteristics;

namespace ZooTycoon.NET.Entities
{
    public abstract class Unit<TSubType, TCharacteristics> : Entity<TSubType, TCharacteristics>
        where TSubType : Enum
        where TCharacteristics : Characteristics, new()
    {
    }
}

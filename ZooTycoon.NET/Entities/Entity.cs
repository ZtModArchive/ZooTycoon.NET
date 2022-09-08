using System.Collections.ObjectModel;
using ZooTycoon.NET.DataModels.Enums;
using ZooTycoon.NET.DataModels.Sections.Animations;
using ZooTycoon.NET.DataModels.Sections.AnimPath;
using ZooTycoon.NET.DataModels.Sections.Characteristics;
using ZooTycoon.NET.DataModels.Sections.Icon;

namespace ZooTycoon.NET.Entities
{
    public abstract class Entity<TSubType, TCharacteristics>
        where TSubType : Enum
        where TCharacteristics : Characteristics, new()
    {
        public string Type { get; set; } = string.Empty;
        public TSubType? SubType { get; set; }
        public Collection<Member> Members { get; set; } = new();
        public bool AvailableAtStartup { get; set; }
        public virtual AnimPath AnimPath { get; set; } = new();
        public virtual Icon Icon { get; set; } = new();
        public virtual TCharacteristics Characteristics { get; set; } = new();
        public virtual Animations? Animations { get; set; }
    }
}

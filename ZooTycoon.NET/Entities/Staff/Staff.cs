using ZooTycoon.NET.DataModels.Classes.Characteristics;
using ZooTycoon.NET.DataModels.Classes.Colors;
using ZooTycoon.NET.DataModels.Enumeration.SubTypes;

namespace ZooTycoon.NET.Entities.Staff
{
    public class Staff : ZTunit
    {
        public StaffSubType? SubType { get; set; }
        public StaffSubType? DefaultSubType { get; set; }
        public Dictionary<StaffSubType, string> Icons { get; set; } = new Dictionary<StaffSubType, string>();
        public Dictionary<StaffSubType, ColorReplace> ColorReplacements { get; set; } = new Dictionary<StaffSubType, ColorReplace>();
        public Dictionary<StaffSubType, StaffCharacteristics> Characteristics { get; set; } = new Dictionary<StaffSubType, StaffCharacteristics>();
    }
}

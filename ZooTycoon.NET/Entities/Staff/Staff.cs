using ZooTycoon.NET.DataModels.Sections.Characteristics;
using ZooTycoon.NET.DataModels.SubTypes;

namespace ZooTycoon.NET.Entities.Animals
{
    public class Staff : ZtUnit<StaffSubType, StaffCharacteristics>
    {
        public Staff(string type) : this()
        {
            Type = type;
        }

        public Staff(string type, StaffSubType subType) : this()
        {
            Type = type;
            SubType = subType;
        }

        public Staff()
        {
        }
    }
}

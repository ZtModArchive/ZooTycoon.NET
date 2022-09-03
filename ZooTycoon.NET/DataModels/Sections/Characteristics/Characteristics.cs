using ZooTycoon.NET.DataModels.Interfaces;

namespace ZooTycoon.NET.DataModels.Sections.Characteristics
{
    public class Characteristics : IDataSection, ICharacteristics
    {
        public int? ChaseTimeOut { get; set; }
        public int? ChaseLookAhead { get; set; }
        public int? PreyRadius { get; set; }
        public int? PredatorRadius { get; set; }
        public int? NonPathCost { get; set; }
        public int? NonPathCostEmergency { get; set; }
    }
}

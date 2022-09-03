using ZooTycoon.NET.DataModels.Sections.Characteristics;

namespace ZooTycoon.NET.Entities
{
    public abstract class ZtUnit<TSubType, TCharacteristics> : Unit<TSubType, TCharacteristics>
        where TSubType : Enum
        where TCharacteristics : Characteristics, new()
    {
        public ZtUnit() : base()
        {
            Characteristics.ChaseTimeOut = 10;
            Characteristics.ChaseLookAhead = 3;
            Characteristics.PreyRadius = 5;
            Characteristics.PredatorRadius = 7;
            Characteristics.NonPathCost = 5;
            Characteristics.NonPathCostEmergency = 1;
        }
    }
}

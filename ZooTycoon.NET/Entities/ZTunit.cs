
namespace ZooTycoon.NET.Entities
{
    public abstract class ZTunit : Unit
    {
        public int ChaseTimeOut { get; set; } = 10;
        public int ChaseLookAhead { get; set; } = 3;
        public int PreyRadius { get; set; } = 5;
        public int PredatorRadius { get; set; } = 7;
        public int NonPathCost { get; set; } = 5;
        public int NonPathCostEmergency { get; set; } = 1;
    }
}

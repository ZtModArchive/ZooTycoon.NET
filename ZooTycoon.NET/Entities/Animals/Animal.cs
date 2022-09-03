using ZooTycoon.NET.DataModels.Sections.Characteristics;
using ZooTycoon.NET.DataModels.SubTypes;

namespace ZooTycoon.NET.Entities.Animals
{
    public class Animal : ZtUnit<AnimalsSubType, AnimalCharacteristics>
    {
        public Animal(string type) : this()
        {
            Type = type;
        }

        public Animal(string type, AnimalsSubType subType) : this()
        {
            Type = type;
            SubType = subType;
        }

        public Animal() : base()
        {
            Characteristics.CaptivityCheck = 20;
            Characteristics.OtherCheck = 40;
            Characteristics.KeeperCheck = 30;
            Characteristics.SocialCheck = 30;
            Characteristics.HungerCheck = 30;
            Characteristics.HealthCheck = 30;
            Characteristics.EnergyCheck = 30;
            Characteristics.EscapedCheck = 2;
            Characteristics.ReproductionCheck = 20;
            Characteristics.HabitatCheck = 20;
            Characteristics.BuildingUseCheck = 20;
            Characteristics.BoredCheck = 30;
            Characteristics.WaterCheck = 40;
            Characteristics.ZapCheck = 5;
            Characteristics.BreathCheck = 30;
            Characteristics.UIThreshold = 75;
            Characteristics.KeeperArrivesChange = 25;
            Characteristics.KeeperArrivesChangeAmphibious = 35;
            Characteristics.MatePickDelay = 3;
            Characteristics.DeathChance = 100;
            Characteristics.DeathChange = -20;
            Characteristics.DirtChanceChance = 5;
            Characteristics.DirtChance = 5;
            Characteristics.BoxedCheck = 2;
            Characteristics.RattleChance = 20;
            Characteristics.DefenseRadius = 3;
        }
    }
}

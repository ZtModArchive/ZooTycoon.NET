using ZooTycoon.NET.DataModels.Classes.Text;
using ZooTycoon.NET.DataModels.Training;
using ZooTycoon.NET.Entities.Poo;

namespace ZooTycoon.NET.DataModels.Classes.Characteristics
{
    public class StaffCharacteristics : UnitCharacteristics
    {
        public IEnumerable<StaffTraining>? Trainings { get; set; }
        public int? WorkCheck { get; set; }
        public int? FoodPerTile { get; set; }
        public int? SicklyAnimalPct { get; set; }
        public int? WeaponRange { get; set; }
        public int? FoodUnitsSecond { get; set; }
        public int? CleanTime { get; set; }
        public int? HealUnitsSecond { get; set; }
        public int? CleanTankPct { get; set; }
        public int? CleanTankThreshold { get; set; }
        public IEnumerable<Poo>? Dirts { get; set; }
        public int? CrowdCheck { get; set; }
        public int? CrowdRadius { get; set; }
        public int? Followchance { get; set; }
        public int? InformGuestTime { get; set; }
        public int? TourGuideBonus { get; set; }
        public TranslatableText DutiesText { get; set; } = new TranslatableText();
        public int? MaxGroupSize { get; set; }
        public int? ReleaseChance { get; set; }
    }
}

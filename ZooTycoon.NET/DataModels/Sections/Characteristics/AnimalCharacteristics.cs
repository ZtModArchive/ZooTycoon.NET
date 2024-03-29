﻿using System.Collections.ObjectModel;
using ZooTycoon.NET.DataModels.Enums;
using ZooTycoon.NET.Entities.Animals;
using ZooTycoon.NET.Entities.Scenery;

namespace ZooTycoon.NET.DataModels.Sections.Characteristics
{
    public class AnimalCharacteristics : Characteristics
    {
        public int? CaptivityCheck { get; set; }
        public int? OtherCheck { get; set; }
        public int? KeeperCheck { get; set; }
        public int? SocialCheck { get; set; }
        public int? HungerCheck { get; set; }
        public int? HealthCheck { get; set; }
        public int? EnergyCheck { get; set; }
        public int? EscapedCheck { get; set; }
        public int? ReproductionCheck { get; set; }
        public int? HabitatCheck { get; set; }
        public int? BuildingUseCheck { get; set; }
        public int? BoredCheck { get; set; }
        public int? WaterCheck { get; set; }
        public int? ZapCheck { get; set; }
        public int? BreathCheck { get; set; }
        public int? UIThreshold { get; set; }
        public int? KeeperArrivesChange { get; set; }
        public int? KeeperArrivesChangeAmphibious { get; set; }
        public int? MatePickDelay { get; set; }
        public int? DeathChance { get; set; }
        public int? DeathChange { get; set; }
        public int? DirtChanceChance { get; set; }
        public int? DirtChance { get; set; }
        public int? BoxedCheck { get; set; }
        public int? RattleChance { get; set; }
        public int? DefenseRadius { get; set; }
        public int? IconZoom { get; set; }
        public int? UsesRealShadows { get; set; }
        public int? KeeperFoodType { get; set; }
        public int? PrefIconID { get; set; }
        public int? TimeToHatch { get; set; }
        public int? EggIconZoom { get; set; }
        public int? BoxedIconZoom { get; set; }
        public int? NameID { get; set; }
        public int? HelpID { get; set; }
        public int? PurchaseCost { get; set; }
        public int? InitialHappiness { get; set; }
        public int? SlowRate { get; set; }
        public int? MediumRate { get; set; }
        public int? FastRate { get; set; }
        public int? FootprintX { get; set; }
        public int? FootprintY { get; set; }
        public int? BoxFootprintX { get; set; }
        public int? BoxFootprintY { get; set; }
        public int? BoxFootprintZ { get; set; }
        public int? EggFootprintX { get; set; }
        public int? EggFootprintY { get; set; }
        public int? EggFootprintZ { get; set; }
        public int? Captivity { get; set; }
        public int? NoFoodChange { get; set; }
        public int? SickChange { get; set; }
        public int? OtherAnimalSickChange { get; set; }
        public int? CrowdHappinessChange { get; set; }
        public int? OtherAnimalAngryChange { get; set; }
        public int? NumberMinChange { get; set; }
        public int? NumberMaxChange { get; set; }
        public int? AllCrowdedChange { get; set; }
        public int? AngryHabitatChange { get; set; }
        public int? VeryAngryHabitatChange { get; set; }
        public int? NotEnoughKeepersChange { get; set; }
        public int? AngryTreeChange { get; set; }
        public int? BabyBornChange { get; set; }
        public int? HappyHabitatChange { get; set; }
        public int? MaxHits { get; set; }
        public int? MinHits { get; set; }
        public int? PctHits { get; set; }
        public int? HungerThreshold { get; set; }
        public int? HungerIncrement { get; set; }
        public int? NeededFood { get; set; }
        public int? KeeperFoodUnitsEaten { get; set; }
        public int? HungryHealthChange { get; set; }
        public int? SickChance { get; set; }
        public int? EnergyThreshold { get; set; }
        public int? EnergyIncrement { get; set; }
        public int? MaxEnergy { get; set; }
        public int? Crowd { get; set; }
        public int? KeeperFrequency { get; set; }
        public int? Social { get; set; }
        public int? HabitatSize { get; set; }
        public int? NumberAnimalsMin { get; set; }
        public int? NumberAnimalsMax { get; set; }
        public int? AnimalDensity { get; set; }
        public int? PctHabitat { get; set; }
        public int? HabitatPreference { get; set; }
        public int? DirtyHabitatRating { get; set; }
        public int? DirtyIncrement { get; set; }
        public int? DirtyThreshold { get; set; }
        public int? PooWaterImpact { get; set; }
        public int? MurkyWaterChange { get; set; }
        public int? MurkyWaterThreshold { get; set; }
        public int? VeryMurkyWaterChange { get; set; }
        public int? VeryMurkyWaterThreshold { get; set; }
        public int? ExtremelyMurkyWaterChange { get; set; }
        public int? ExtremelyMurkyWaterThreshold { get; set; }
        public int? ReproductionChance { get; set; }
        public int? ReproductionInterval { get; set; }
        public int? BabyToAdult { get; set; }
        public int? HappyReproduceThreshold { get; set; }
        public int? Offspring { get; set; }
        public int? MatingType { get; set; }
        public int? NoMateChange { get; set; }
        public int? BashStrength { get; set; }
        public int? Keeper { get; set; }
        public int? WaterNeeded { get; set; }
        public int? LandNeeded { get; set; }
        public int? EnterWaterChance { get; set; }
        public int? EnterLandChance { get; set; }
        public int? UnderwaterNeeded { get; set; }
        public int? EnterTankChance { get; set; }
        public int? EscapedChange { get; set; }
        public int? SickTime { get; set; }
        public int? Mimic { get; set; }
        public int? MimicHappyDiff { get; set; }
        public int? OtherFood { get; set; }
        public int? FoodTypes { get; set; }
        public int? TreePref { get; set; }
        public int? RockPref { get; set; }
        public int? SpacePref { get; set; }
        public int? ElevationPref { get; set; }
        public int? SalinityChange { get; set; }
        public int? SalinityHealthChange { get; set; }
        public int? TimeDeath { get; set; }
        public int? EatVegetationChance { get; set; }
        public int? DrinkWaterChance { get; set; }
        public int? ChaseAnimalChance { get; set; }
        public int? ClimbsCliffs { get; set; }
        public int? BuildingUseChance { get; set; }
        public int? Attractiveness { get; set; }
        public int? BreathThreshold { get; set; }
        public int? BreathIncrement { get; set; }

        public bool? HasShadowImages { get; set; }
        public bool? HasUnderwaterSection { get; set; }
        public bool? LaysEggs { get; set; }
        public bool? EatsEggs { get; set; }
        public bool? HeliRecovery { get; set; }
        public bool? Walkable { get; set; }
        public bool? Tall { get; set; }
        public bool? BabiesAttack { get; set; }
        public bool? Preattack { get; set; }
        public bool? ResetPreyPosition { get; set; }
        public bool? IsJumper { get; set; }
        public bool? IsClimber { get; set; }
        public bool? IsManEater { get; set; }
        public bool? CrushesFences { get; set; }
        public bool? Flies { get; set; }
        public bool? Swims { get; set; }
        public bool? Underwater { get; set; }
        public bool? DinoZoodoo { get; set; }
        public bool? SmallZoodoo { get; set; }
        public bool? NeedShelter { get; set; }
        public bool? IsSpecialAnimal { get; set; }

        public string? GeneralInfoTextName { get; set; }
        public string? PlaqueImageName { get; set; }
        public string? ListImageName { get; set; }

        public Family? Family { get; set; }
        public Genus? Genus { get; set; }
        public Habitat? Habitat { get; set; }
        public Location? Location { get; set; }
        public Era? Era { get; set; }
        public IEnumerable<Animal>? PreyList { get; set; }
        public Dictionary<Family, int>? CompatibleAnimals { get; set; }
        public Dictionary<Scenery, int>? SuitableObjects { get; set; }
        public Dictionary<Terrain, int>? CompatibleTerrain { get; set; }
    }
}

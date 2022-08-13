namespace ZooTycoon.NET.DataModels.Classes.Characteristics
{
    public class UnitCharacteristics : Characteristics
    {
        public string? GeneralInfoTextName { get; set; }
        public string? PlaqueImageName { get; set; }
        public string? InfoImageName { get; set; }
        public string ListImageName { get; set; } = string.Empty;
        public int SlowRate { get; set; }
        public int MediumRate { get; set; }
        public int FastRate { get; set; }
        public int? ChaseCheck { get; set; }
    }
}

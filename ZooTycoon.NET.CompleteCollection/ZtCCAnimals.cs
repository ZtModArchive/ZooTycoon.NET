using ZooTycoon.NET.CompleteCollection.Enums;
using ZooTycoon.NET.Entities.Animals;

namespace ZooTycoon.NET.CompleteCollection
{
    public static class ZtCCAnimals
    {
        public static Dictionary<ZtCCAnimal, Animal> Animals { get; } = new();
        static ZtCCAnimals()
        {
            foreach (ZtCCAnimal ztCCAnimal in Enum.GetValues(typeof(ZtCCAnimal)))
            {
                Animals.Add(
                    ztCCAnimal,
                    new(Enum.GetName(ztCCAnimal)!){
                        Characteristics = new()
                        {
                            NameID = (int?)ztCCAnimal,
                            HelpID = (int?)ztCCAnimal
                        }
                    }
                );
            }
        }
    }
}

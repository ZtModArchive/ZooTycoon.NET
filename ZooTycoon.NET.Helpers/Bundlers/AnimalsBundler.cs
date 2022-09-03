using ZooTycoon.NET.DataModels.Sections.Characteristics;
using ZooTycoon.NET.DataModels.SubTypes;
using ZooTycoon.NET.Entities.Animals;

namespace ZooTycoon.NET.Helpers.Bundlers
{
    public class AnimalsBundler : EntityBundler<AnimalsSubType, AnimalCharacteristics, Animal>
    {
        public AnimalsBundler(string type) : base(type)
        {
        }
        public AnimalsBundler(Animal entity) : base(entity)
        {
        }
    }
}

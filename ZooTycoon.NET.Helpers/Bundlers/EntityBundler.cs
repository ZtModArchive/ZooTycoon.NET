using ZooTycoon.NET.DataModels.Sections.Characteristics;
using ZooTycoon.NET.Entities;
using ZooTycoon.NET.Helpers.Interfaces;

namespace ZooTycoon.NET.Helpers.Bundlers
{
    public class EntityBundler<TSubType, TCharacteristics, TEntity> : IEntityBundler<TSubType, TCharacteristics, TEntity>
        where TSubType : Enum
        where TCharacteristics : Characteristics, new()
        where TEntity : Entity<TSubType, TCharacteristics>
    {
        private Dictionary<TSubType, TEntity> _entities = new();

        public string Type { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public TSubType DefaultSubType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public IEntityBundler<TSubType, TCharacteristics, TEntity> AddEntity(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public IEntityBundler<TSubType, TCharacteristics, TEntity> AutoFillBundler()
        {
            throw new NotImplementedException();
        }

        public IEntityBundler<TSubType, TCharacteristics, TEntity> ClearBundler()
        {
            throw new NotImplementedException();
        }

        public TEntity GetDefaultEntity()
        {
            throw new NotImplementedException();
        }

        public IEntityBundler<TSubType, TCharacteristics, TEntity> RemoveEntity(TSubType subType)
        {
            throw new NotImplementedException();
        }
    }
}

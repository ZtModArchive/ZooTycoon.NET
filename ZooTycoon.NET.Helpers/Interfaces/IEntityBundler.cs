using ZooTycoon.NET.DataModels.Sections.Characteristics;
using ZooTycoon.NET.Entities;

namespace ZooTycoon.NET.Helpers.Interfaces
{
    public interface IEntityBundler<TSubType, TCharacteristics, TEntity>
        where TSubType : Enum
        where TCharacteristics : Characteristics, new()
        where TEntity : Entity<TSubType, TCharacteristics>
    {
        public string Type { get; set; }
        public TSubType DefaultSubType { get; set; }
        public TEntity GetDefaultEntity();
        public IEntityBundler<TSubType, TCharacteristics, TEntity> AddEntity(TEntity entity);
        public IEntityBundler<TSubType, TCharacteristics, TEntity> RemoveEntity(TSubType subType);
        public IEntityBundler<TSubType, TCharacteristics, TEntity> AutoFillBundler();
        public IEntityBundler<TSubType, TCharacteristics, TEntity> ClearBundler();
    }
}
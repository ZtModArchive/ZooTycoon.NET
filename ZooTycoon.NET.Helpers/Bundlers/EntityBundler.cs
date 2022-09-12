using ZooTycoon.NET.DataModels.Sections.Characteristics;
using ZooTycoon.NET.Entities;
using ZooTycoon.NET.Helpers.Interfaces;

namespace ZooTycoon.NET.Helpers.Bundlers
{
    public abstract class EntityBundler<TSubType, TCharacteristics, TEntity> : IEntityBundler<TSubType, TCharacteristics, TEntity>
        where TSubType : Enum
        where TCharacteristics : Characteristics, new()
        where TEntity : Entity<TSubType, TCharacteristics>, new()
    {
        private readonly Dictionary<TSubType, TEntity> _entities = new();

        public string Type { get; set; }
        public TSubType DefaultSubType { get; set; }
        protected EntityBundler(string type)
        {
            TEntity entity = new()
            {
                Type = type,
                SubType = default
            };

            Type = entity.Type;
            DefaultSubType = entity.SubType!;

            AddEntity(entity);
        }
        protected EntityBundler(TEntity entity)
        {
            Type = entity.Type;

            if (entity.SubType != null)
            {
                DefaultSubType = entity.SubType;
            }
            else
            {
                DefaultSubType = default!;
            }

            AddEntity(entity);
        }
        public TEntity GetEntity(TSubType subType)
        {
            return _entities[subType];
        }

        public IEntityBundler<TSubType, TCharacteristics, TEntity> AddEntity(TEntity entity)
        {
            if (entity.SubType != null)
            {
                _entities.Add(entity.SubType, entity);
            }
            else
            {
                throw new ArgumentException("Entity SubType must not be null");
            }

            return this;
        }

        public IEntityBundler<TSubType, TCharacteristics, TEntity> AutoFillBundler()
        {
            foreach (TSubType subType in Enum.GetValues(typeof(TSubType)))
            {
                if (_entities.ContainsKey(subType))
                {
                    continue;
                }

                _entities.Add(subType, new());
            }

            return this;
        }

        public IEntityBundler<TSubType, TCharacteristics, TEntity> ClearBundler()
        {
            _entities.Clear();
            return this;
        }

        public TEntity GetDefaultEntity()
        {
            return _entities.Where(kv => kv.Key.Equals(DefaultSubType)).First().Value;
        }

        public IEntityBundler<TSubType, TCharacteristics, TEntity> RemoveEntity(TSubType subType)
        {
            _entities.Remove(subType);
            return this;
        }
    }
}

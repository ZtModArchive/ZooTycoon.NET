using ZooTycoon.NET.DataModels.Enumeration;

namespace ZooTycoon.NET.Entities
{
    public abstract class Entity
    {
        /// <summary>
        /// Unique ID of the Entity
        /// </summary>
        public string Type { get; set; } = string.Empty;

        /// <summary>
        /// Defines which Expansions this Entity should be filtered in
        /// </summary>
        public IEnumerable<Expansion> ExpansionMembers { get; set; } = Enumerable.Empty<Expansion>();

        /// <summary>
        /// The Expansion this Entity was added in
        /// </summary>
        public Expansion Expansion { get; set; }
    }
}

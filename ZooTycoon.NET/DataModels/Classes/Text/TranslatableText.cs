using ZooTycoon.NET.DataModels.Enumeration;

namespace ZooTycoon.NET.DataModels.Classes.Text
{
    public class TranslatableText
    {
        public int Id { get; set; }
        public Dictionary<Language, string> Strings { get; set; } = new Dictionary<Language, string>();
    }
}

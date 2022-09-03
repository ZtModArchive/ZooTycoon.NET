using ZooTycoon.NET.DataModels.SubTypes;
using ZooTycoon.NET.Helpers.Bundlers;

namespace ZooTycoon.Net.Helpers.Tests.AnimalsBundlerTests
{
    public class ConstructorTests
    {
        [Theory]
        [InlineData("butterfly")]
        public void ItShould_CreateANewAnimalsBundler_WithStringArgument (string typeName)
        {
            AnimalsBundler bundler = new(typeName);

            Assert.Equal(bundler.DefaultSubType, new AnimalsSubType());
            Assert.Equal(bundler.GetDefaultEntity().Type, typeName);
        }
    }
}

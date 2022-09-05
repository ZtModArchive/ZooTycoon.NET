using ZooTycoon.NET.DataModels.SubTypes;
using ZooTycoon.NET.Entities.Animals;
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

            Assert.Equal(bundler.Type, bundler.GetDefaultEntity().Type);
            Assert.Equal(bundler.DefaultSubType, new AnimalsSubType());
            Assert.Equal(bundler.GetDefaultEntity().Type, typeName);
            Assert.Equal(bundler.GetEntity(AnimalsSubType.m), bundler.GetDefaultEntity());
        }

        [Fact]
        public void ItShould_CreateANewAnimalsBundler_WithEntityArgument()
        {
            AnimalsBundler bundler = new(new Animal("butterfly", AnimalsSubType.f));

            Assert.Equal(bundler.Type, bundler.GetDefaultEntity().Type);
            Assert.Equal(AnimalsSubType.f, bundler.DefaultSubType);
            Assert.Equal("butterfly", bundler.GetDefaultEntity().Type);
        }
    }
}

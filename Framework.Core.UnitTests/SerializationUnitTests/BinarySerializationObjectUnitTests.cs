using Framework.Core.UnitTests.SerializationUnitTests.FakeObjects;
using Framework.Serialization;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Core.UnitTests.SerializationUnitTests
{
    [TestFixture]
    public class BinarySerializationObjectUnitTests
    {
        public BinarySerializationObject BinarySerializationObject { get; private set; }

        [SetUp]
        public void Setup()
        {
            BinarySerializationObject = new BinarySerializationObject();
        }

        [Test]
        public void Json_Serialization_Should_Be_Success()
        {
            FakeCategory category = FakeCategoryCreator.CreateCategory(1, "Beverages");

            var serializationResult = this.BinarySerializationObject.Serialize(category);

            Assert.NotNull(serializationResult);
        }

        [Test]
        public void Json_Deserialization_Should_Be_Success()
        {
            FakeCategory category = FakeCategoryCreator.CreateCategory(1, "Beverages");

            var serializationResult = this.BinarySerializationObject.Serialize(category);

            byte[] bytes = serializationResult;

            var deserializationResult = this.BinarySerializationObject.Deserialize(bytes, typeof(FakeCategory));

            Assert.NotNull(deserializationResult);
        }
    }
}

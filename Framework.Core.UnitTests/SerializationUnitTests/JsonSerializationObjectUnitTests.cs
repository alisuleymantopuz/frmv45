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
    public class JsonSerializationObjectUnitTests
    {
        public JsonSerializationObject JsonSerializationObject { get; private set; }

        [SetUp]
        public void Setup()
        {
            JsonSerializationObject = new JsonSerializationObject();
        }

        [Test]
        public void Json_Serialization_Should_Be_Success()
        {
            FakeCategory category = FakeCategoryCreator.CreateCategory(1, "Beverages");

            var serializationResult = this.JsonSerializationObject.Serialize(category);

            Assert.NotNull(serializationResult);
        }

        [Test]
        public void Json_Deserialization_Should_Be_Success()
        {
            string jsonValue = "{\"Id\":1,\"Name\":\"Beverages\"}";

            var deserializationResult = this.JsonSerializationObject.Deserialize(jsonValue, typeof(FakeCategory));

            Assert.NotNull(deserializationResult);
        }
    }
}

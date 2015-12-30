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
  public  class XmlSerializationObjectUnitTests
    {
        public XmlSerializationObject XmlSerializationObject { get; private set; }

        [SetUp]
        public void Setup()
        {
            XmlSerializationObject = new XmlSerializationObject();
        }

        [Test]
        public void Json_Serialization_Should_Be_Success()
        {
            FakeCategory category = FakeCategoryCreator.CreateCategory(1, "Beverages");

            var serializationResult = this.XmlSerializationObject.Serialize(category);

            Assert.NotNull(serializationResult);
        }

        [Test]
        public void Json_Deserialization_Should_Be_Success()
        {
            string xmlValue = "<?xml version=\"1.0\" encoding=\"utf-16\"?><FakeCategory xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\"><Id>1</Id><Name>Beverages</Name></FakeCategory>";

            var deserializationResult = this.XmlSerializationObject.Deserialize(xmlValue, typeof(FakeCategory));

            Assert.NotNull(deserializationResult);
        }
    }
}

using Framework.Core.UnitTests.SpecificationUnitTests.FakeObjects;
using Framework.Core.UnitTests.SpecificationUnitTests.FakeObjects.Rules;
using Framework.Specifications;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Core.UnitTests.SpecificationUnitTests
{
    [TestFixture]
    public class BusinessSpecificationRuleUnitTests
    {
        [Test]
        public void CategoryMustBeDefined_BusinessRule_Should_Be_Checked_Success()
        {
            CategoryMustBeDefined categoryMustBeDefined = new CategoryMustBeDefined();

            Product product = FakeProductObject.CreateProduct();

            BusinessSpecificationResult<Product> businessSpecificationResult = categoryMustBeDefined.CheckRules(product);

            Assert.IsNull(businessSpecificationResult.BusinessSpecificationMessage);
        }

        [Test]
        public void PriceMustBeGreaterThanZero_BusinessRule_Should_Be_Returns_2311()
        {
            PriceMustBeGreaterThanZero priceMustBeGreaterThanZero = new PriceMustBeGreaterThanZero();

            Product product = FakeProductObject.CreateProduct();

            BusinessSpecificationResult<Product> businessSpecificationResult = priceMustBeGreaterThanZero.CheckRules(product);

            Assert.IsNotNull(businessSpecificationResult.BusinessSpecificationMessage);

            Assert.AreEqual(businessSpecificationResult.BusinessSpecificationMessage.Code,"2311");
        }

        [Test]
        public void ProductCanNotNull_BusinessRule_Should_Be_Returns_1311()
        {
            ProductCanNotNull productCanNotNull = new ProductCanNotNull();

            Product product = FakeProductObject.CreateProduct();

            BusinessSpecificationResult<Product> businessSpecificationResult = productCanNotNull.CheckRules(product);

            Assert.IsNotNull(businessSpecificationResult.BusinessSpecificationMessage);

            Assert.AreEqual(businessSpecificationResult.BusinessSpecificationMessage.Code, "1311");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Core.UnitTests.SpecificationUnitTests.FakeObjects.Specifications;
using NUnit.Framework;
using Framework.Core.UnitTests.SpecificationUnitTests.FakeObjects;
using Framework.Specifications;

namespace Framework.Core.UnitTests.SpecificationUnitTests
{
    [TestFixture]
    public class ExpressionSpecificationsUnitTests
    {
        [Test]
        public void MobilePremiumAndSmartSpecification_Should_Be_Checked_Success()
        {
            Mobile mobile = new Mobile(MobileBrandName.Apple, MobileType.Smart, 700);

            ISpecification<Mobile> mobilePremiumAndSmartSpecification = new MobilePremiumAndSmartSpecification();

            var result = mobilePremiumAndSmartSpecification.IsSatisfiedBy(mobile);

            Assert.AreEqual(true, result);
        }

        [Test]
        public void ExpressionAndCompositeSpecification_Should_Be_Checked_Success()
        {
            Mobile mobile = new Mobile(MobileBrandName.Apple, MobileType.Smart, 700);

            ISpecification<Mobile> appleSpecification = new ExpressionSpecification<Mobile>(x=>x.BrandName == MobileBrandName.Apple);

            ISpecification<Mobile> priceSpecification = new ExpressionSpecification<Mobile>(x => x.Cost >= 600);

            ISpecification<Mobile> compositeSpecification = appleSpecification.And(priceSpecification);

            var result = compositeSpecification.IsSatisfiedBy(mobile);

            Assert.AreEqual(true, result);
        }
    }
}

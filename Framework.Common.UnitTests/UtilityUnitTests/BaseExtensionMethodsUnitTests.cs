using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Utility.Extensions;
using Framework.Common.UnitTests.UtilityUnitTests.FakeObjects;

namespace Framework.Common.UnitTests.UtilityUnitTests
{
    [TestFixture]
    public class BaseExtensionMethodsUnitTests
    {
        [Test]
        public void Type_Should_Be_Correct_Format()
        {
            FakeCategory categoryOne = FakeCategoryCreator.CreateCategory(1, "Beverages");
            FakeCategory categoryTwo = FakeCategoryCreator.CreateCategory(2, "Cheeses");

            bool isSame = categoryOne.IsOfType<FakeCategory>();

            Assert.IsTrue(isSame);
        }

        [Test]
        public void TypeComparison_Should_Be_Correct_Format()
        {
            FakeCategory categoryOne = FakeCategoryCreator.CreateCategory(1, "Beverages");
            FakeCategory categoryTwo = FakeCategoryCreator.CreateCategory(2, "Cheeses");

            bool isSame = categoryOne.IsOfType(typeof(FakeCategory));

            Assert.IsTrue(isSame);

        }
    }
}

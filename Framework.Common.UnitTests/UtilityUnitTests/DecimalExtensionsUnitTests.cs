using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Utility.Extensions;

namespace Framework.Common.UnitTests.UtilityUnitTests
{
    [TestFixture]
    public class DecimalExtensionsUnitTests
    {
        [Test]
        public void ToUIString_Should_Be_Success()
        {
            decimal value = 12.12M;

            string uiString = value.ToUIString();

            Assert.IsNotNull(uiString);

        }

        [Test]
        public void IsEqualMoney_Should_Be_Success()
        {
            decimal value = 12.12M;

            decimal theOtherValue = 23.12M;

            bool comparisonResult = value.IsEqualMoney(theOtherValue);

            Assert.AreEqual(comparisonResult, false);

        }
    }
}

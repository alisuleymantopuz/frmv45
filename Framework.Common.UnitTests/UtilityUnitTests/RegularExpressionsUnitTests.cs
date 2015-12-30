using Framework.Utility.RegularExpressions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Framework.Common.UnitTests.UtilityUnitTests
{
    [TestFixture]
    public class RegularExpressionsUnitTests
    {
        [Test]
        public void CurrencyPattern_Should_Be_Correct_Format()
        {
            string pattern = RegularExpressionResources.CurrencyPattern;

            bool isMatched = Regex.IsMatch("12.00", pattern);

            Assert.IsTrue(isMatched);
        }

        [Test]
        public void EmailPattern_Should_Be_Correct_Format()
        {
            string pattern = RegularExpressionResources.EmailPattern;

            bool isMatched = Regex.IsMatch("a@vt.t.co", pattern);

            Assert.IsTrue(isMatched);
        }

        [Test]
        public void PhonePattern_Should_Be_Correct_Format()
        {
            string pattern = RegularExpressionResources.PhonePattern;

            bool isMatched = Regex.IsMatch("5555554422", pattern);

            Assert.IsTrue(isMatched);
        }

        [Test]
        public void ShortDatePattern_Should_Be_Correct_Format()
        {
            string pattern = RegularExpressionResources.ShortDatePattern;

            bool isMatched = Regex.IsMatch("12/12/2014", pattern);

            Assert.IsTrue(isMatched);
        }

        [Test]
        public void UrlPattern_Should_Be_Correct_Format()
        {
            string pattern = RegularExpressionResources.UrlPattern;

            bool isMatched = Regex.IsMatch("http://www.h.com", pattern);

            Assert.IsTrue(isMatched);
        }
    }
}

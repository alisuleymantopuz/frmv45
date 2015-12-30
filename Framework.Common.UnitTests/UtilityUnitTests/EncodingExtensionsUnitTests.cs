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
    public class EncodingExtensionsUnitTests
    {
        [Test]
        public void ToStringByEncoding_Should_Be_Success()
        {
            string value = "Microsoft Visual Studio";

            string changedValue = value.ToStringByEncoding(Encoding.UTF8);

            Assert.IsNotNull(changedValue);
        }
    }
}

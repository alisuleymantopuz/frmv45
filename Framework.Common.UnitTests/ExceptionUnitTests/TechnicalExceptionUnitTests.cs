using Framework.Common.UnitTests.ExceptionUnitTests.FakeObjects;
using Framework.Exception;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Common.UnitTests.ExceptionUnitTests
{
    [TestFixture]
    public class TechnicalExceptionUnitTests
    {
        [Test]
        public void Thrown_ClientIdAndPasswordIsWrong_BusinessException_Should_Be_Success()
        {
            FakeTechnicalObject fakeTechnicalObject = new FakeTechnicalObject();

            var exception = Assert.Throws<TechnicalException>(() => fakeTechnicalObject.CheckSystem());

            Assert.AreEqual(exception.Message, ((int)TechnicalExceptionCodes.SystemError).ToString());

        }
    }
}

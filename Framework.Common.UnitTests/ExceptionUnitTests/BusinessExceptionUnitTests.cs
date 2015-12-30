using Framework.Common.UnitTests.ExceptionUnitTests.FakeObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Exception;
using NUnit.Framework;

namespace Framework.Common.UnitTests.ExceptionUnitTests
{
    [TestFixture]
    public class BusinessExceptionUnitTests
    {
        [Test]
        public void Thrown_ClientIdAndPasswordIsWrong_BusinessException_Should_Be_Success()
        {
            FakeBusinessObject fakeBusinessObject = new FakeBusinessObject();

            var exception = Assert.Throws<BusinessException>(() => fakeBusinessObject.CheckClientIdAndPassword(string.Empty, string.Empty));

            Assert.AreEqual(exception.Message, ((int)BusinessExceptionCodes.ClientIdAndPasswordIsWrong).ToString());

        }

        [Test]
        public void Thrown_ThisRecordAlreadyExists_BusinessException_Should_Be_Success()
        {
            FakeBusinessObject fakeBusinessObject = new FakeBusinessObject();

            var exception = Assert.Throws<BusinessException>(() => fakeBusinessObject.CheckRecordAcceptability(string.Empty));

            Assert.AreEqual(exception.Message, ((int)BusinessExceptionCodes.ThisRecordAlreadyExists).ToString());

        }
    }
}

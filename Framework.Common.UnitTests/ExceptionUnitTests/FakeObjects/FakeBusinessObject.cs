using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Exception;

namespace Framework.Common.UnitTests.ExceptionUnitTests.FakeObjects
{
    public class FakeBusinessObject
    {
        public void CheckClientIdAndPassword(string clientId, string password)
        {
            throw new BusinessException(((int)BusinessExceptionCodes.ClientIdAndPasswordIsWrong).ToString());
        }

        public void CheckRecordAcceptability(string record)
        {
            throw new BusinessException(((int)BusinessExceptionCodes.ThisRecordAlreadyExists).ToString());
        }
    }
}

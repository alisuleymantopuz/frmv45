using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Exception;

namespace Framework.Common.UnitTests.ExceptionUnitTests.FakeObjects
{
    public class FakeTechnicalObject
    {
        public void CheckSystem()
        {
            throw new TechnicalException((int)TechnicalExceptionCodes.SystemError);
        }
    }
}

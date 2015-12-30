using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Framework.Exception
{
    public class BusinessException : BaseException
    {
        public BusinessException(List<int> errorCodes)
            : base(errorCodes)
        {

        }

        public BusinessException(int errorCode)
            : base(errorCode)
        {

        }

        public BusinessException(string message)
            : base(message)
        {

        }
    }
}

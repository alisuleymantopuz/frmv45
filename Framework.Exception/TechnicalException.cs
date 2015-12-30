using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Framework.Exception
{
    public class TechnicalException : BaseException
    {
        public TechnicalException(List<int> errorCodes)
            : base(errorCodes)
        {

        }

        public TechnicalException(int errorCode)
            : base(errorCode)
        {

        }

        public TechnicalException(string message)
            : base(message)
        {

        }
    }
}

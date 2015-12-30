using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Framework.Exception
{
    public enum TechnicalExceptionCodes
    {
        SystemError = 1001,
        Error = 2000,
        CommunicationError = 2001,
        RequestError = 2002,
        UnknownResponseCode = 9999,
    }
}

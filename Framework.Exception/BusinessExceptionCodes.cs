using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Framework.Exception
{
    public enum BusinessExceptionCodes
    {
        #region GenericExceptions
        ThisRecordAlreadyExists = 3001,
        ThisRecordNotExists = 3002,
        #endregion

        #region Client-Security
        ClientIdAndPasswordIsWrong = 3007,
        ClientRequestIdIsNull = 3008,
        ClientRequestIdIsTooLong = 3009,
        ClientIdIsNull = 3010,
        ClientPasswordIsNull = 3011,
        ClientPasswordIsTooLong = 3012,
        ClientRequestDateTimeIsNull = 3013,
        RequestInfoIsNull = 3014,
        #endregion

        #region PagedSearch
        PageIndexIsLessThanOrEqualToZero = 3015,
        PageSizeIsLessThanOrEqualToZero = 3016,
        #endregion
    }
}

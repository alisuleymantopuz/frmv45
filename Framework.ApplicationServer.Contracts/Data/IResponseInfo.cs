using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Framework.ApplicationServer.Contracts.Data
{
    public interface IResponseInfo
    {
        ResponseStatus Status { get; set; }

        string ResponseCode { get; set; }

        string ResponseMessage { get; set; }

        DateTime ResponseDateTime { get; set; }

        bool IsIdempotent { get; set; }
    }
}

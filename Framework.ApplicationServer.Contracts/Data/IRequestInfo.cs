using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Framework.ApplicationServer.Contracts.Data
{
    public interface IRequestInfo
    {
        int ClientId { get; set; }

        string ClientPassword { get; set; }

        DateTime ClientRequestDateTime { get; set; }

        string ClientRequestId { get; set; }
    }
}

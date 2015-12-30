using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Framework.ApplicationServer.Contracts.Data
{
    public interface IRequestBase
    {
        IRequestInfo RequestInfo { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Framework.ApplicationServer.Contracts.Data
{
    public interface IPagedRequestBase : IRequestBase
    {
        IPagedRequestInfo PagedRequestInfo { get; set; }
    }




}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Framework.ApplicationServer.Contracts.Data
{
    [DataContract]
    public class PagedRequestBase : RequestBase
    {
        [DataMember]
        public PagedRequestInfo PagedRequestInfo { get; set; }
    }
}

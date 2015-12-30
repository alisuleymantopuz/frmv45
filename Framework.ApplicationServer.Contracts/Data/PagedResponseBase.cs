using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Framework.ApplicationServer.Contracts.Data
{
    [DataContract]
    public class PagedResponseBase :ResponseBase
    {
        [DataMember]
        public PagedResponseInfo PagedResponseInfo { get; set; }
    }
}

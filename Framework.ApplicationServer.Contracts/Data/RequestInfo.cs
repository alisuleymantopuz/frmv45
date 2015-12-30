using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Framework.ApplicationServer.Contracts.Data
{
    [DataContract]
    public class RequestInfo
    {
        [DataMember]
        public virtual int ClientId { get; set; }
        [DataMember]
        public virtual string ClientPassword { get; set; }
        [DataMember]
        public virtual DateTime ClientRequestDateTime { get; set; }
        [DataMember]
        public virtual string ClientRequestId { get; set; }
    }
}

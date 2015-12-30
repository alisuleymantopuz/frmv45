using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Framework.ApplicationServer.Contracts.Data
{
    [DataContract]
    public class ResponseInfo
    {
        [DataMember]
        public virtual ResponseStatus ResponseStatus { get; set; }

        [DataMember]
        public virtual string ResponseCode { get; set; }

        [DataMember]
        public virtual string ResponseMessage { get; set; }

        [DataMember]
        public virtual DateTime ResponseDateTime { get; set; }

        [DataMember]
        public virtual bool IsIdempotent { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Framework.ApplicationServer.Contracts.Data
{
    [DataContract]
    public class PagedRequestInfo
    {
        [DataMember]
        public virtual int PageIndex { get; set; }

        [DataMember]
        public virtual int PageSize { get; set; }


    }
}

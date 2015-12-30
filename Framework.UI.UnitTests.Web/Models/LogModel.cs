using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Framework.UI.UnitTests.Web.Models
{
    public class LogModel
    {
        public LogModel()
        {
            this.RequestDate = new DateTime(2014, 11, 2, 3, 2, 4);
        }
        
        public DateTime RequestDate { get; set; }
    }
}
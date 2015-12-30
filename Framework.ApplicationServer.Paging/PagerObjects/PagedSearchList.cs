using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Framework.ApplicationServer.Helpers.PagerObjects
{
    public class PagedSearchList<T>
    {
        public int TotalItemCount { get; set; }

        public int PageIndex { get; set; }

        public int PageSize { get; set; }

        public List<T> SearchList { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Framework.ApplicationServer.Helpers.PagerObjects
{
    public interface IPagedBaseManager
    {
        void SetPageIndexAndSizeIfItsNotExist(PagedBase pagedBase);
    }
}

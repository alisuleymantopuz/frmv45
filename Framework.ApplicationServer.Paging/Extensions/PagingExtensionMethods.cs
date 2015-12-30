using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.ApplicationServer.Contracts.Data;
using Framework.ApplicationServer.Helpers.PagerObjects; 

namespace Framework.ApplicationServer.Helpers.Extensions
{
    public static class PagingExtensionMethods
    {
        public static PagedSearchList<T> ToPage<T>(this IEnumerable<T> collection, PagedBase pagedBase)
        {
            PagedSearchList<T> pagedSearchList = new PagedSearchList<T>();
            pagedSearchList.PageIndex = pagedBase.PageIndex;
            pagedSearchList.PageSize = pagedBase.PageSize;

            var enumerable = collection as T[] ?? collection.ToArray();
            pagedSearchList.TotalItemCount = enumerable.Count();
            pagedSearchList.SearchList =
            enumerable.Skip((pagedBase.PageIndex - 1) * pagedBase.PageSize)
                    .Take(pagedBase.PageSize)
                    .ToList();

            return pagedSearchList;
        }

        public static PagedSearchList<T> ToPage<T>(this IEnumerable<T> collection, PagedRequestInfo pagedRequestInfo)
        {
            PagedSearchList<T> pagedSearchList = new PagedSearchList<T>();
            pagedSearchList.PageIndex = pagedRequestInfo.PageIndex;
            pagedSearchList.PageSize = pagedRequestInfo.PageSize;

            var enumerable = collection as T[] ?? collection.ToArray();
            pagedSearchList.TotalItemCount = enumerable.Count();
            pagedSearchList.SearchList =
            enumerable.Skip((pagedRequestInfo.PageIndex - 1) * pagedRequestInfo.PageSize)
                    .Take(pagedRequestInfo.PageSize)
                    .ToList();

            return pagedSearchList;
        }
    }
}

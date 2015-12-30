using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.ApplicationServer.Contracts;
using Framework.ApplicationServer.Contracts.Data;
using Framework.ApplicationServer.Helpers.Extensions;
using Framework.ApplicationServer.Helpers.PagerObjects; 

namespace Framework.Core.UnitTests.ApplicationServerContractsUnitTests.FakeObjects
{
    public class FakePagingObject
    {
        public PagedSearchList<int> PagedIntegerCollection(PagedRequestInfo pagedRequestInfo)
        {

            PagedSearchList<int> pagedSearchList = new PagedSearchList<int>();
            pagedSearchList.PageIndex = pagedRequestInfo.PageIndex;
            pagedSearchList.PageSize = pagedRequestInfo.PageSize;
            pagedSearchList.TotalItemCount = this.IntegerCollection.Count;
            pagedSearchList.SearchList =
                this.IntegerCollection.Skip((pagedRequestInfo.PageIndex - 1) * pagedRequestInfo.PageSize)
                    .Take(pagedRequestInfo.PageSize)
                    .ToList();
            return pagedSearchList;
        }

        public PagedSearchList<int> PagedIntegerCollectionWithExtension(PagedRequestInfo pagedRequestInfo)
        {
            PagedSearchList<int> pagedSearchList = this.IntegerCollection.ToPage(pagedRequestInfo);

            return pagedSearchList;
        }

        public List<int> IntegerCollection
        {
            get { return Enumerable.Range(1, 1000).ToList(); }
        }
    }
}

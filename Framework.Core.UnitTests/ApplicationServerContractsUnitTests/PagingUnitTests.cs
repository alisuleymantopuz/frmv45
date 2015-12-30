using Framework.ApplicationServer.Contracts;
using Framework.ApplicationServer.Contracts.Data;
using Framework.Core.UnitTests.ApplicationServerContractsUnitTests.FakeObjects;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Core.UnitTests.ApplicationServerContractsUnitTests
{
    [TestFixture]
    public class PagingUnitTests
    {
        [Test]
        public void Paging_Should_Be_Success()
        {
            PagedRequestInfo pagedRequestInfo = new PagedRequestInfo();
            pagedRequestInfo.PageSize = 10;
            pagedRequestInfo.PageIndex = 1;

            FakePagingObject fakePagingObject = new FakePagingObject();
            var result = fakePagingObject.PagedIntegerCollection(pagedRequestInfo);

            Assert.NotNull(result);

            Assert.AreEqual(result.PageSize, 10);

            Assert.AreEqual(result.SearchList.Count, 10);
        }


        [Test]
        public void Paging_With_Extension_Should_Be_Success()
        {
            PagedRequestInfo pagedRequestInfo = new PagedRequestInfo();
            pagedRequestInfo.PageSize = 5;
            pagedRequestInfo.PageIndex = 1;

            FakePagingObject fakePagingObject = new FakePagingObject();
            var result = fakePagingObject.PagedIntegerCollectionWithExtension(pagedRequestInfo);

            Assert.NotNull(result);

            Assert.AreEqual(result.PageSize, 5);

            Assert.AreEqual(result.SearchList.Count, 5);
        }
    }
}

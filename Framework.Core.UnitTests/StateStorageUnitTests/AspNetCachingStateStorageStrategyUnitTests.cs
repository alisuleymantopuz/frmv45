using Framework.StateStorage;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Core.UnitTests.StateStorageUnitTests
{
    [TestFixture]
    public class AspNetCachingStateStorageStrategyUnitTests
    {

        public AspNetCachingStateStorageStrategy AspNetCachingStateStorageStrategy { get; private set; }
        [SetUp]
        public void Setup()
        {

            this.AspNetCachingStateStorageStrategy = new AspNetCachingStateStorageStrategy();

        }

        [Test]
        public void Put_Should_Be_Success()
        {
            CacheItem cacheItem = new CacheItem(int.MaxValue);

            this.AspNetCachingStateStorageStrategy.Put("cacheItem01", cacheItem);

            var cacheItemGetted = this.AspNetCachingStateStorageStrategy.Get("cacheItem01");

            Assert.IsNotNull(cacheItemGetted);
        }

        [Test]
        public void Get_Should_Be_Success()
        {
            CacheItem cacheItem = new CacheItem(int.MaxValue);

            this.AspNetCachingStateStorageStrategy.Put("cacheItem01", cacheItem);

            var cacheItemGetted = this.AspNetCachingStateStorageStrategy.Get("cacheItem01");

            Assert.IsNotNull(cacheItemGetted);
        }

        [Test]
        public void Remove_Should_Be_Success()
        {
            CacheItem cacheItem = new CacheItem(int.MaxValue);

            this.AspNetCachingStateStorageStrategy.Put("cacheItem01", cacheItem);

            this.AspNetCachingStateStorageStrategy.Remove("cacheItem01");

            var cacheItemGetted = this.AspNetCachingStateStorageStrategy.Get("cacheItem01");

            Assert.IsNull(cacheItemGetted);
        }
    }
}

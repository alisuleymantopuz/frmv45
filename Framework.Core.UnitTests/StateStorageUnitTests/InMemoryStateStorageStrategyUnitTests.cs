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
    public class InMemoryStateStorageStrategyUnitTests
    {
        public InMemoryStateStorageStrategy InMemoryStateStorageStrategy { get; private set; }
       
        [SetUp]
        public void Setup()
        {

            this.InMemoryStateStorageStrategy = new InMemoryStateStorageStrategy();

        }

        [Test]
        public void Put_Should_Be_Success()
        {
            CacheItem cacheItem = new CacheItem(int.MaxValue);

            this.InMemoryStateStorageStrategy.Put("cacheItem01", cacheItem);

            var cacheItemGetted = this.InMemoryStateStorageStrategy.Get("cacheItem01");

            Assert.IsNotNull(cacheItemGetted);
        }

        [Test]
        public void Get_Should_Be_Success()
        {
            CacheItem cacheItem = new CacheItem(int.MaxValue);

            this.InMemoryStateStorageStrategy.Put("cacheItem01", cacheItem);

            var cacheItemGetted = this.InMemoryStateStorageStrategy.Get("cacheItem01");

            Assert.IsNotNull(cacheItemGetted);
        }

        [Test]
        public void Remove_Should_Be_Success()
        {
            CacheItem cacheItem = new CacheItem(int.MaxValue);

            this.InMemoryStateStorageStrategy.Put("cacheItem01", cacheItem);

            this.InMemoryStateStorageStrategy.Remove("cacheItem01");

            var cacheItemGetted = this.InMemoryStateStorageStrategy.Get("cacheItem01");

            Assert.IsNull(cacheItemGetted);
        }

    }
}

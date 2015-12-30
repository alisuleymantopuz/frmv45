using Framework.Configuration;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Core.UnitTests.ConfigurationUnitTests
{
    [TestFixture]
    public class FrameworkConfigurationUnitTests
    {
        public IConfigurationStore ConfigurationStore { get; private set; }
        public FrameworkConfiguration FrameworkConfiguration { get; private set; }

        [SetUp]
        public void Setup()
        {
            this.ConfigurationStore = new ConfigurationStore();
            this.FrameworkConfiguration = new FrameworkConfiguration(this.ConfigurationStore);
        }

        [Test]
        public void ApplicationKey_Should_Be_Defined()
        {
            string value = this.FrameworkConfiguration.ApplicationKey;

            Assert.NotNull(value);
        }

        [Test]
        public void ApplicationName_Should_Be_Defined()
        {
            string value = this.FrameworkConfiguration.ApplicationName;

            Assert.NotNull(value);
        }

        [Test]
        public void ApplicationVersion_Should_Be_Defined()
        {
            string value = this.FrameworkConfiguration.ApplicationVersion;

            Assert.NotNull(value);
        }


    }
}

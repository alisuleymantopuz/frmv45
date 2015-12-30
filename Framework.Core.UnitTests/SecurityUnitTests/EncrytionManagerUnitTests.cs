using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Configuration;
using NUnit.Framework;
using Framework.Security;

namespace Framework.Core.UnitTests.SecurityUnitTests
{
    [TestFixture]
    public class EncrytionManagerUnitTests
    {
        public IConfigurationStore ConfigurationStore { get; private set; }
        public FrameworkConfiguration FrameworkConfiguration { get; private set; }
        public IEncryptionManager EncryptionManager { get; private set; }
        [SetUp]
        public void Setup()
        {
            this.ConfigurationStore = new ConfigurationStore();
            this.FrameworkConfiguration = new FrameworkConfiguration(this.ConfigurationStore);
            this.EncryptionManager = new EncryptionManager(this.FrameworkConfiguration);
        }

        [Test]
        public void Encryption_Should_Be_Success()
        {
            string value = "Microsoft Visual Studio";

            string encryptedValue = this.EncryptionManager.Encrypt(value);

            Assert.IsNotNull(encryptedValue);
        }

        [Test]
        public void Decryption_Should_Be_Success()
        {
            string value = "hnRmDTWx5/8eF48riJtRUYpJDsmhAGSa";

            string expectedDecryptedValue = "Microsoft Visual Studio";

            string actualDecryptedValue = this.EncryptionManager.Decrypt(value);

            Assert.IsNotNull(actualDecryptedValue);

            Assert.AreEqual(expectedDecryptedValue,actualDecryptedValue);
        }
    }
}

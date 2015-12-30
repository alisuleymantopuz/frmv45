using Castle.Windsor;
using Castle.Windsor.Installer;
using Framework.Container;
using Framework.Exception;
using Framework.Logging;
using Framework.Logging.NLog;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Core.UnitTests.LoggingUnitTests
{
    [TestFixture]
    public class FileLoggingUnitTests
    {
        public IWindsorContainer WindsorContainer { get; set; }


        [SetUp]
        public void Setup()
        {
            WindsorContainer = new WindsorContainer();
            WindsorContainer
                .Install(new FrameworkConfigurationInstaller())
                .Install(new DatabaseErrorLogWindsorInstaller());

        }

        [Test]
        public void ObjectSerializing_ForJsonSerializer_Should_Be_Success()
        {
            var jsonSerializer = this.WindsorContainer.Resolve<IObjectSerializer>();

            var serializedData = jsonSerializer.Serialize(DateTime.Now);

            Assert.NotNull(serializedData);
        }

        [Test]
        public void Logging_ForMethodLogger_Should_Be_Success()
        {
            var methodLogger = this.WindsorContainer.Resolve<IMethodLogger>();

            string referenceId = Guid.NewGuid().ToString().Replace("-", "").ToUpper();

            Assert.NotNull(methodLogger);

            methodLogger.WriteMethodEntry(referenceId, MethodBase.GetCurrentMethod(), new List<object>() { DateTime.Now });

            methodLogger.WriteMethodExit(referenceId, MethodBase.GetCurrentMethod(), new List<object>() { DateTime.Now }, DateTime.Now);
        }

        [Test]
        public void Logging_ForExceptionLogger_Should_Be_Success()
        {
            var exceptionLogger = this.WindsorContainer.Resolve<IExceptionLogger>();

            string referenceId = Guid.NewGuid().ToString().Replace("-", "").ToUpper();

            Assert.NotNull(exceptionLogger);

            try
            {
                throw new BusinessException(((int)TechnicalExceptionCodes.SystemError));
            }
            catch (System.Exception exception)
            {
                exceptionLogger.WriteException(exception, referenceId);
            }
        }

        [Test]
        public void Logging_ForTraceLogger_Should_Be_Success()
        {
            var traceLogger = this.WindsorContainer.Resolve<ITraceLogger>();

            string referenceId = Guid.NewGuid().ToString().Replace("-", "").ToUpper();

            Assert.NotNull(traceLogger);

            traceLogger.Write("Write method debugging..", LoggerLevel.Debug, MethodBase.GetCurrentMethod(), referenceId);

            traceLogger.Write("Writeinfo method debugging with error logger level..", LoggerLevel.Error, MethodBase.GetCurrentMethod(), referenceId);
        }
    }
}

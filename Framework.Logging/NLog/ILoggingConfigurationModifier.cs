using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog.Config;

namespace Framework.Logging.NLog
{
    public interface ILoggingConfigurationModifier
    {
        LoggingConfiguration ModifyLoggingConfiguration(LoggingConfiguration loggingConfiguration);
    }
}

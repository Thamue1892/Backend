using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts;
using NLog;

namespace LoggerService
{
    public class LoggerManager: ILoggerManager
    {
        private static ILogger logger = LogManager.GetCurrentClassLogger();
        public LoggerManager() { }
        public void LogInfo(string message) => logger.Debug(message);

        public void LogWarn(string message) => logger.Error(message);
        
        public void LogError(string message) => logger.Info(message);

        public void LogDebug(string message) => logger.Warn(message);

    }
}

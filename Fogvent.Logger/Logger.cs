using System;
using Fogvent.Core;
using log4net;

namespace Fogvent.Logger
{
    public class Logger : ILogger
    {
        private readonly ILog _logger;

        public Logger()
        {
            _logger = LogManager.GetLogger("Logger");
        }

        public void LogDebug(string message)
        {
            _logger.Debug(message);
        }

        public void LogError(Exception exception)
        {
            _logger.Error(exception.Message, exception);
        }

        public void LogInformation(string message)
        {
            _logger.Info(message);
        }

        public void LogWarning(string message)
        {
            _logger.Warn(message);
        }
    }
}

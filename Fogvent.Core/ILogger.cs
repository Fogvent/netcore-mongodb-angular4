using System;

namespace Fogvent.Core
{
    public interface ILogger
    {
        void LogDebug(string message);
        void LogWarning(string message);
        void LogInformation(string message);
        void LogError(Exception exception);
    }
}

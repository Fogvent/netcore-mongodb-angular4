using System;

namespace Fogvent.Services
{
    public interface ILogger
    {
        void LogDebug(string message);
        void LogWarning(string message);
        void LogInformation(string message);
        void LogError(Exception exception);
    }
}

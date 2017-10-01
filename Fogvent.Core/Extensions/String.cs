using System.Configuration;

namespace Fogvent.Core.Extensions
{
    public static class String
    {
        public static string GetConfigurationValue(this string key)
        {
            return ConfigurationSettings.AppSettings.Get(key);
        }
    }
}

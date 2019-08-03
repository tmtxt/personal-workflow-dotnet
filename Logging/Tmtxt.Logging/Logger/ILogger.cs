using System.Collections.Generic;
using Tmtxt.Logging.Constants;

namespace Tmtxt.Logging.Logger
{
    /// <summary>
    /// An interface for pushing out the log with format
    /// </summary>
    public interface ILogger
    {
        void Log(LogLevel logLevel, string message, IDictionary<string, object> props);
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using Tmtxt.Logging.Constants;
using Tmtxt.Logging.Logger;

namespace Tmtxt.Logging.LogTrace
{
    public class LogTrace : ILogTrace
    {
        #region Constructors

        public LogTrace(IEnumerable<ILogger> loggers)
        {
            Loggers = loggers;
        }

        #endregion

        #region Other props

        /// <summary>
        /// List of loggers
        /// </summary>
        protected readonly IEnumerable<ILogger> Loggers;

        /// <summary>
        /// List of all log entries
        /// </summary>
        protected readonly LinkedList<LogEntry> LogEntries = new LinkedList<LogEntry>();

        /// <summary>
        /// Extra props
        /// </summary>
        protected IDictionary<string, object> Properties = new Dictionary<string, object>();

        /// <summary>
        /// Locking
        /// </summary>
        protected readonly object Lock = new object();

        #endregion

        #region Implement ILogTrace

        /// <inheritdoc />
        public void Push(LogLevel logLevel, string title, object message, DateTime? startedAt = null)
        {
            lock (Lock)
            {
                var logEntry = new LogEntry { LogLevel = logLevel, Title = title, Message = message };
                LogEntries.AddLast(logEntry);
            }
        }

        /// <inheritdoc />
        public void ExtendProps(string key, object value)
        {
            Properties[key] = value;
        }

        /// <inheritdoc />
        public void Flush()
        {
            var logString = BuildLogString();

            foreach (var logger in Loggers)
            {
                logger.Log(LogLevel.Info, logString, Properties);
            }
        }

        #endregion

        #region Helpers

        private string BuildLogString()
        {
            var logStrings = LogEntries.Select((entry, idx) => $"{idx} - {entry.BuildLogString()}");
            return string.Join("\n", logStrings);
        }

        #endregion
    }
}
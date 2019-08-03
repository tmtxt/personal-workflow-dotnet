using System;
using System.Collections.Generic;
using Tmtxt.Logging.Constants;
using Tmtxt.Logging.Logger;

namespace Tmtxt.Logging.LogTrace
{
    public class LogTrace : ILogTrace
    {
        #region Constructors

        public LogTrace(IEnumerable<ILogger> loggers)
        {
            _loggers = loggers;
        }

        #endregion

        #region Props

        /// <summary>
        /// List of loggers
        /// </summary>
        private readonly IEnumerable<ILogger> _loggers;

        /// <summary>
        /// List of all log entries
        /// </summary>
        protected readonly LinkedList<LogEntry> LogEntries = new LinkedList<LogEntry>();

        /// <summary>
        /// Locking
        /// </summary>
        protected readonly object Lock = new object();

        #endregion

        #region Implement ILogTrace

        public void Push(LogLevel logLevel, string title, object message, DateTime? startedAt = null)
        {
            lock (Lock)
            {
                var logEntry = new LogEntry { LogLevel = logLevel, Title = title, Message = message };
                LogEntries.AddLast(logEntry);
            }
        }

        public void Flush()
        {
            foreach (var logger in _loggers)
            {
                logger.Log(LogLevel.Info, "test", new Dictionary<string, object>());
            }
        }

        #endregion

        #region Helpers

        #endregion
    }
}
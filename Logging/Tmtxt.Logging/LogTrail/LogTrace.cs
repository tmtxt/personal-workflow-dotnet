using System;
using System.Collections.Generic;
using Tmtxt.Logging.Constants;

namespace Tmtxt.Logging.LogTrail
{
    public class LogTrace : ILogTrace
    {
        #region Constructors

        #endregion

        #region Props

        /// <summary>
        /// List of all log entries
        /// </summary>
        protected LinkedList<LogEntry> LogEntries = new LinkedList<LogEntry>();

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
        }

        #endregion

        #region Helpers

        #endregion
    }
}
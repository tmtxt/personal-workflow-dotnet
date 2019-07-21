using System;
using Tmtxt.Logging.Constants;

namespace Tmtxt.Logging
{
    /// <summary>
    /// Interface for LogTrail
    /// </summary>
    public interface ILogTrail
    {
        /// <summary>
        /// Add a new log entry to the instance
        /// </summary>
        /// <param name="logLevel"></param>
        /// <param name="title"></param>
        /// <param name="message"></param>
        /// <param name="startedAt"></param>
        void Add(LogLevel logLevel, string title, object message, DateTime? startedAt);

        /// <summary>
        /// Flush out this log instance
        /// </summary>
        void Flush();
    }
}
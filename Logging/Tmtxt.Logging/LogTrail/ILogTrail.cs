using System;
using Tmtxt.Logging.Constants;

namespace Tmtxt.Logging.LogTrail
{
    /// <summary>
    /// Interface for LogTrail
    /// A LogTrail holds all the related messages and flush out at the same time
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
        void Push(LogLevel logLevel, string title, object message, DateTime? startedAt = null);

        /// <summary>
        /// Flush out this log instance
        /// </summary>
        void Flush();
    }
}
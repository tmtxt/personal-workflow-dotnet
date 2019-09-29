using System;
using Tmtxt.Logging.Constants;

namespace Tmtxt.Logging.LogTrace
{
    /// <summary>
    /// Interface for LogTrail
    /// A LogTrail holds all the related messages and flush out at the same time
    /// </summary>
    public interface ILogTrace
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
        /// Add extra properties to this instance
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        void ExtendProps(string key, object value);

        /// <summary>
        /// Flush out this log instance
        /// </summary>
        void Flush();
    }
}
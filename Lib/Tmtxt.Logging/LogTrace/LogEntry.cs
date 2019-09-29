using Newtonsoft.Json;
using Tmtxt.Logging.Constants;

namespace Tmtxt.Logging.LogTrace
{
    public class LogEntry
    {
        /// <summary>
        /// The log level of this entry
        /// </summary>
        public LogLevel LogLevel { get; set; }

        /// <summary>
        /// Log title
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Message content
        /// </summary>
        public object Message { get; set; }

        /// <summary>
        /// Time elapsed from previous log entry
        /// </summary>
        public double? TimeElapsed { get; set; }

        /// <summary>
        /// Build the log string for this instance
        /// </summary>
        /// <returns></returns>
        public string BuildLogString()
        {
            var message = JsonConvert.SerializeObject(Message, Formatting.Indented);
            return $"[{LogLevel.ToString().ToUpper()}] - {Title} - {message}";
        }
    }
}
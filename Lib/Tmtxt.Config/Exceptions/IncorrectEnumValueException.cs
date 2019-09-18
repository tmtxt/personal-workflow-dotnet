using System;

namespace Tmtxt.Config.Exceptions
{
    public class IncorrectEnumValueException : Exception
    {
        public IncorrectEnumValueException(string configKey, string configValue) : base(
            $"Config {configKey} value {configValue} is not in Enum value list")
        {
        }
    }
}
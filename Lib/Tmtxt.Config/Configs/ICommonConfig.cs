using Tmtxt.Config.Constants;

namespace Tmtxt.Config.Configs
{
    /// <summary>
    /// Common, shared configuration
    /// </summary>
    public interface ICommonConfig : IConfig
    {
        SystemTypeEnum SystemType { get; set; }
    }
}
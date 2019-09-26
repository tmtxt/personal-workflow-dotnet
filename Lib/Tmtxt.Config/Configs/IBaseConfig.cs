using Tmtxt.Config.Constants;

namespace Tmtxt.Config.Configs
{
    /// <summary>
    /// Common, shared configuration
    /// </summary>
    public interface IBaseConfig : IConfig
    {
        SystemTypeEnum SystemType { get; set; }
    }
}
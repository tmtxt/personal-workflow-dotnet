namespace Tmtxt.Config.Configs
{
    /// <summary>
    /// Common, shared configuration
    /// </summary>
    public interface IBaseConfig : IConfig
    {
        string Environment { get; set; }
    }
}
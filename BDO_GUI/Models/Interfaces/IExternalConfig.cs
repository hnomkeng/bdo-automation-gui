namespace BDO_GUI.Models.Interfaces
{
    public interface IExternalConfig
    {
        ExternalConfigSetting Setting { get; set; }
        bool UseWorker { get; set; }
        bool UseProcessing { get; set; }
        bool UseTray { get; set; }
    }
}

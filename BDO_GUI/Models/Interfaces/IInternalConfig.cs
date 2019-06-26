using System;

namespace BDO_GUI.Models.Interfaces
{
    public interface IInternalConfig
    {
        WorkerConfig Worker { get; set; }
        ProcessingConfig Processing { get; set; }
        TrayConfig Tray { get; set; }

        string TargetApplicationPartialName { get; set; }
        IntPtr TargetApplicationPtr { get; set; }
        int RepeatTimer { get; set; }

        bool IsRunning { get; set; }
    }
}

using System;
using System.Collections.ObjectModel;
using BDO_GUI.Models.Interfaces;

namespace BDO_GUI.Models
{
    public class InternalConfig : IInternalConfig
    {
        public WorkerConfig Worker { get; set; }
        public ProcessingConfig Processing { get; set; }
        public TrayConfig Tray { get; set; }

        public string TargetApplicationPartialName { get; set; }
        public IntPtr TargetApplicationPtr { get; set; }
        public int RepeatTimer { get; set; }

        public bool IsRunning { get; set; }
    }

    public class WorkerConfig
    {
        public bool IsActive { get; set; }
    }

    public class ProcessingConfig
    {
        public bool IsActive { get; set; }
        public bool UseVenecil { get; set; }
        public ObservableCollection<string> Items { get; set; }
    }

    public class TrayConfig
    {
        public bool IsActive { get; set; }
    }
}

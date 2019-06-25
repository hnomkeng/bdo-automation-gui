namespace BDO_GUI.Models.Interfaces
{
    public interface IInternalCalibrationSetup
    {
        WorkerCalibrationSetup Worker { get; }
        ProcessingCalibrationSetup Processing { get; }
        AreaCalibrationSetup Area { get; }
        TrayCalibrationSetup Tray { get; }
    }
}

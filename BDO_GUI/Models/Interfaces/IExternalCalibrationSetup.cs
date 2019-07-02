namespace BDO_GUI.Models.Interfaces
{
    public interface IExternalCalibrationSetup
    {
        CalibrationLandMark CalibrationLandMarks { get; set; }
        CalibrationScreenZone CalibrationScreenZone { get; set; }
        int DegreeToWidth { get; set; }
    }
}

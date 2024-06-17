namespace JKCSystem.Core.Interfaces.Models.Domain.Parts
{
    internal interface ICooler
    {
        int FanCount { get; set; }
        string Fans { get; }
        string FanSize { get; set; }
        string BearingType { get; set; }
        string RPM { get; set; }
        int CFM { get; set; }
        string AirFlow { get; }
        int DBA { get; set; }
        string NoiseLevel { get; set; }
    }
}

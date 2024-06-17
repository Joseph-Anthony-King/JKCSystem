namespace JKCSystem.Core.Interfaces.Models.Domain.Parts
{
    internal interface ICaseTemplate : IPart
    {
        List<string> MotherboardCompatability { get; set; }
        bool FanControllerIncluded { get; set; }
        bool ARGBControllerIncluded { get; set; }
        string MaxCPUCoolerHeight { get; set; }
        string LED { get; set; }
    }
}

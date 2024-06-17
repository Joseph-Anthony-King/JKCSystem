using JKCSystem.Core.Enums;

namespace JKCSystem.Core.Interfaces.Models.Domain.Parts
{
    internal interface IGPUTemplate : IPart
    {
        Brand ChipSetManufacturer { get; set; }
        string Interface { get; set; }
        string GPUSeries { get; set; }
        string GPU { get; set; }
        string StreamProcessors { get; set; }
        string EffectiveMemoryClock { get; set; }
        string MemorySize { get; set; }
        string MemoryInterface { get; set; }
        string MemoryTypes { get; set; }
        bool DirectX { get; set; }
        bool OpenGL { get; set; }
        int NumberOfMonitors { get; set; }
        int NumberOfHDMIPorts { get; set; }
        int NumberOfDisplayPorts { get; set; }
        string MaxResolution { get; set; }
        string ThermalPowerDesign { get; set; }
        string RecommendedPSUWattage { get; set; }
    }
}

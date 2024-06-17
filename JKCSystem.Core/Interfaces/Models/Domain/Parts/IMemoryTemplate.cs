using JKCSystem.Core.Enums.Memory;

namespace JKCSystem.Core.Interfaces.Models.Domain.Parts
{
    internal interface IMemoryTemplate : IPart
    {
        MemoryCapacity Capacity { get; set; }
        string CapacityDescription { get; }
        int SticksPerKit { get; set; }
        MemorySpeed Speed { get; set; }
        string SpeedDescription { get; }
        int CASLatency { get; set; }
        int TRCD { get; set; }
        int TRP { get; set; }
        int TRAS { get; set; }
        string Timing { get; }
        MemoryVoltage Voltage { get; set; }
        string VoltageDescription { get; }
        MemoryChannelKit MultiChannelKit { get; set; }
        string MultiChannelKitDescription { get; }
        MemoryBiosProfile BiosProfile { get; set; }
        string BiosProfileDescription { get; }
    }
}

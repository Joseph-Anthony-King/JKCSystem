using JKCSystem.Core.Enums;
using JKCSystem.Core.Enums.CPU;

namespace JKCSystem.Core.Interfaces.Models.Domain.Parts
{
    internal interface ICPUTemplate : IPart
    {
        ProcessorType ProcessorType { get; set; }
        string ProcessTypeDescription { get; }
        CPUSocketType CPUSocketType { get; set; }
        string CPUSocketTypeDescription { get; }
        CPUSeries CPUSeries { get; set; }
        string CPUSeriesDescription { get; }
        CPUNumberOfCore NumberOfCores { get; set; }
        string NumberOfCoresDescription { get; }
        CPUNumberOfThreads NumberOfThreads { get; set; }
        string NumberOfThreadsDescription { get; set; }
        Bytes L1Cache { get; set; }
        string L1CacheDescription { get; }
        Bytes L2Cache { get; set; }
        string L2CacheDescription { get; }
        Bytes L3Cache { get; set; }
        string L3CacheDescription { get; }
        bool AMD64BitSupport { get; set; }
        Hertz OperatingFrequency { get; set; }
        string OperatingFrequencyDescription { get; }
        Hertz MaxOperatingFrequency { get; set; }
        string MaxOperatingFrequencyDescription { get; }
        CPUMemoryTypes MemoryTypes { get; set; }
        string MemoryTypesDescription { get; }
        Bytes MaxMemorySize { get; set; }
        string MaxMemorySizeDescription { get; }
        Watts ThermalDesignPower { get; set; }
        string ThermalDesignPowerDescription { get; }
    }
}

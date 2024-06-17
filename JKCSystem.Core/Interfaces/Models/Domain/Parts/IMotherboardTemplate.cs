using JKCSystem.Core.Enums;
using JKCSystem.Core.Enums.CPU;
using JKCSystem.Core.Enums.Motherboard;

namespace JKCSystem.Core.Interfaces.Models.Domain.Parts
{
    internal interface IMotherboardTemplate : IPart
    {
        MotherboardFormFactor FormFactor { get; set; }
        string FormFactorDescription { get; set; }
        CPUSocketType CPUSocketType { get; set; }
        string CPUSocketTypeDescription { get; }
        string CPUType { get; set; }
        MotherboardChipset ChipSet { get; set; }
        string ChipSetDescription { get; }
        MotherboardNumberOfMemorySlots NumberOfMemorySlots { get; set; }
        string NumberOfMemorySlotsDescription { get; }
        CPUMemoryTypes MemoryStandard { get; set; }
        string MemoryStandardDescription { get; }
        Bytes MaximumMemorySupported { get; set; }
        string MaximumMemorySupportedDescription { get; }
        MotherboardChannelSupported ChannelSupported { get; set; }
        string ChannelSupportedDescription { get; }
        string AudioChipset { get; set; }
        string AudioChannels { get; set; }
        string RearPanelPorts { get; set; }
        string OtherConnectors { get; set; }
    }
}

using System.ComponentModel;

namespace JKCSystem.Core.Enums
{
    public enum PartType
    {
        [Description("CPU")]
        CPU,
        [Description("Motherboard")]
        MOTHERBOARD,
        [Description("Memory")]
        MEMORY,
        [Description("GPU")]
        GPU,
        [Description("Case")]
        CASE,
        [Description("Power Supply")]
        POWERSUPPLY,
        [Description("Storage")]
        STORAGE,
        [Description("CPU Cooler/AIO")]
        CPUCOOLER,
        [Description("Operating System")]
        OPERATINGSYSTEM,
        [Description("Case Fan")]
        CASEFAN,
        [Description("Accessory")]
        ACCESSORY
    }
}

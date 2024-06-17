using System.ComponentModel;

namespace JKCSystem.Core.Enums.Motherboard
{
    internal enum MotherboardNumberOfMemorySlots
    {
        [Description("2x288pin (DDR5)")]
        DDR52,
        [Description("2x288pin (DDR4)")]
        DDR42,
        [Description("2x240pin")]
        PIN2240,
        [Description("4x288pin (DDR5)")]
        DDR54,
        [Description("4x288pin (DDR4)")]
        DDR44,
        [Description("4x240pin")]
        PIN4240,
        [Description("8x288pin (DDR4)")]
        DDR48
    }
}

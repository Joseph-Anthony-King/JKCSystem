using System.ComponentModel;

namespace JKCSystem.Core.Enums.CPU
{
    internal enum CPUSocketType
    {
        [Description("Socket AM5")]
        AM5,
        [Description("Socket sTR5")]
        STR5,
        [Description("Socket sWRX8")]
        SWWRX8,
        [Description("Socket AM4")]
        AM4,
        [Description("FM2+")]
        FM2,
        [Description("LGA 1700")]
        LGA1700,
        [Description("LGA 1200")]
        LGA1200,
        [Description("LGA 2066")]
        LGA2066,
        [Description("LGA 1151 (300 Series)")]
        LGA1151300,
        [Description("LGA 1151")]
        LGA1151,
        [Description("LGA 775")]
        LGA775
    }
}

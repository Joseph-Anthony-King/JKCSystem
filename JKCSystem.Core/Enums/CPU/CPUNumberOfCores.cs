using System.ComponentModel;

namespace JKCSystem.Core.Enums.CPU
{
    internal enum CPUNumberOfCore
    {
        [Description("96-Core")]
        CORE96,
        [Description("64-Core")]
        CORE64,
        [Description("32-Core")]
        CORE32,
        [Description("24-Core (8P+16E)")]
        CORE248P16E,
        [Description("24-Core")]
        CORERE24,
        [Description("20-Core (8P+12E)")]
        CORE208P12E,
        [Description("16-Core (8P+8E)")]
        CORE168P8E,
        [Description("16-Core")]
        CORE16,
        [Description("14-Core (6P+8E)")]
        CORE146P8E,
        [Description("14-Core")]
        CORE14,
        [Description("12-Core (8P+4E)")]
        CORE128P4E,
        [Description("12-Core")]
        CORE12,
        [Description("10-Core (6P+4E)")]
        CORE106P4E,
        [Description("10-Core")]
        CORE10,
        [Description("8-Core")]
        CORE8,
        [Description("6-Core")]
        CORE6,
        [Description("4-Core (4P+0E)")]
        CORE44P0E,
        [Description("Quad-Core")]
        CORE4,
        [Description("2-Core (2P+0E)")]
        CORE22P0E,
        [Description("Dual-Core")]
        CORE2,
    }
}

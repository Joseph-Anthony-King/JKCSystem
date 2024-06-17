using System.ComponentModel;

namespace JKCSystem.Core.Enums.Motherboard
{
    internal enum MotherboardFormFactor
    {
        [Description("ATX")]
        ATX,
        [Description("Enhanced Extended ATX")]
        EEATX,
        [Description("Extended ATX")]
        EATX,
        [Description("Micro ATX")]
        MATX,
        [Description("Mini ITX")]
        ITX,
        [Description("CEB")]
        CEB,
        [Description("Mini DTX")]
        MINIDTX,
    }
}

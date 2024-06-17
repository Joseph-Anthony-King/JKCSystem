using System.ComponentModel;

namespace JKCSystem.Core.Enums.Motherboard
{
    internal enum MotherboardChannelSupported
    {
        [Description("Dual Channel")]
        DUALCHANNEL,
        [Description("Tripple Channel")]
        TRIPPLECHANNEL,
        [Description("Quad Channel")]
        QUADCHANNEL,
    }
}

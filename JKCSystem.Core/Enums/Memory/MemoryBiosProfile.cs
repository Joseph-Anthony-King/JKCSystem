using System.ComponentModel;

namespace JKCSystem.Core.Enums.Memory
{
    internal enum MemoryBiosProfile
    {
        [Description("AMD Expo")]
        AMDEXPO,
        [Description("Intel XMP 2.0")]
        XMP2_0,
        [Description("Intel XMP 3.0")]
        XMP3_0,
        [Description("Intel XMP 3.0/AMD Expo")]
        XMP3_0_AMDEXPO,
    }
}

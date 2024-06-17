using System.ComponentModel;

namespace JKCSystem.Core.Enums.Memory
{
    internal enum MemoryCapacity
    {
        [Description("64GB")]
        GB64,
        [Description("96GB (2 x 48GB)")]
        GB96_2x32GB,
        [Description("192GB (4 x 48GB)")]
        GB192_4x32GB,
        [Description("32GB")]
        GB32,
        [Description("64GB (2 x 32GB)")]
        GB64_2x32GB,
        [Description("128GB (4 x 32GB)")]
        GB128_4x32GB,
        [Description("256GB (8 x 32GB)")]
        GB256_8x32GB,
        [Description("24GB (2 x 24GB)")]
        GB24_2x24GB,
        [Description("16GB")]
        GB16,
        [Description("32GB (2 x 16GB)")]
        GB32_2x16GB,
        [Description("64GB (4 x 16GB)")]
        GB64_4x16GB,
        [Description("128GB (8 x 16GB)")]
        GB128_8x16GB,
        [Description("8GB")]
        GB8,
        [Description("16GB (2 x 8GB)")]
        GB16_2x8GB,
        [Description("24GB (3 x 8GB)")]
        GB24_3x8GB,
        [Description("32GB (4 x 8GB)")]
        GB32_4x8GB,
        [Description("64GB (8 x 8GB)")]
        GB64_8x8GB,
    }
}

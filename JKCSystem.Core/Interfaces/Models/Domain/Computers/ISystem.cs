using JKCSystem.Core.Interfaces.Models.Domain.Parts;

namespace JKCSystem.Core.Interfaces.Models.Domain.Computers
{
    internal interface ISystem : IBuild
    {
        List<ICPU> CPU { get; set; }
        List<IMotherboard> Motherboard { get; set; }
        List<IMemory> Memory { get; set; }
        List<IGPU> GPU { get; set; }
        List<ICase> Case { get; set; }
        List<IPowerSupply> PowerSupply { get; set; }
        List<IStorage> Storage { get; set; }
        List<ICPUCooler> CPUCooler { get; set; }
        List<IOperatingSystem> OperatingSystem { get; set; }
        List<ICaseFan> CaseFans { get; set; }
        List<IAccessory> Accessories { get; set; }
    }
}

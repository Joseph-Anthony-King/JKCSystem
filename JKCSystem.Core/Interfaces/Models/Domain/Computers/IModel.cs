
using JKCSystem.Core.Interfaces.Models.Domain.Parts;

namespace JKCSystem.Core.Interfaces.Models.Domain.Computers
{
    internal interface IModel : IBuild
    {
        List<ICPUTemplate> CPU { get; set; }
        List<IMotherboardTemplate> Motherboard { get; set; }
        List<IMemoryTemplate> Memory { get; set; }
        List<IGPUTemplate> GPU { get; set; }
        List<ICaseTemplate> Case { get; set; }
        List<IPowerSupplyTemplate> PowerSupply { get; set; }
        List<IStorageTemplate> Storage { get; set; }
        List<ICPUCoolerTemplate> CPUCooler { get; set; }
        List<IOperatingSystemTemplate> OperatingSystem { get; set; }
        List<ICaseFanTemplate> CaseFans { get; set; }
        List<IAccessoryTemplate> Accessories { get; set; }
    }
}

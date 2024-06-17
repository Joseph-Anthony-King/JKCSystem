namespace JKCSystem.Core.Interfaces.Models.Domain.Parts
{
    internal interface IOperatingSystemTemplate
    {
        string OperatingSystems { get; }
        string BitVersion { get; set; }
    }
}

namespace JKCSystem.Core.Interfaces.Models.Domain.Parts
{
    internal interface IStorageTemplate
    {
        string DeviceType { get; set; }
        string FormFactor { get; set; }
        string Capacity { get; set; }
        string MemoryComponents { get; set; }
        string Interface { get; set; }
        string Controller { get; set; }
        string Cache { get; set; }
        string Encryption { get; set; }
        string MaxSequentialRead { get; set; }
        string MaxSequentialWrite { get; set; }
        string TerrabytesWritten { get; set; }
        string PowerConsumptionIdle { get; set; }
        string PowerConsumptionActive { get; set; }
    }
}

using JKCSystem.Core.Enums;

namespace JKCSystem.Core.Interfaces.Models.Domain.Parts
{
    internal interface IPart : IDomainEntity
    {
        Brand Brand { get; set; }
        string Model { get; set; }
        string Series { get; set; }
        string ImageUrl { get; set; }
        PartType PartType { get; set; }
        string ProductID { get; set; }
        string SerialNumber { get; set; }
        string ProductUrl { get; set; }
        string ProcurementUrl { get; set; }
        int Wattage { get; set; }
        string WattageEstimate { get; }
        string PowerConnector { get; set; }
        ICommercial Manufacturer { get; set; }
        decimal MSRP { get; set; }
        DateTime DateFirstAvailable { get; set; }
        T ConvertToItem<T>(decimal cost, decimal warrantyCost, decimal price = 0);
    }
}

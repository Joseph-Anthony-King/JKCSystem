namespace JKCSystem.Core.Interfaces.Models.Domain
{
    internal interface IWarranty : IDomainEntity
    {
        string WarrantyId { get; set; }
        ICommercial Guarantor { get; set; }
        decimal Cost { get; }
    }
}

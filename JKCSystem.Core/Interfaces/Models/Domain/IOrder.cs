using JKCSystem.Core.Interfaces.Models.Domain.Computers;

namespace JKCSystem.Core.Interfaces.Models.Domain
{
    internal interface IOrder : IDomainEntity
    {
        int OrderID { get; set; }
        string OrderNumber { get; }
        List<IModel> Builds { get; set; }
        IPrivateIndividual Purchaser { get; set; }
        ICommercial ShippingInsurer { get; set; }
        IWarranty Warranty { get; set; }
        double PartsCost { get; }
        double WarrantyCost { get; }
        double ShippingInsurance { get; }
        double TotalCost { get; }
    }
}

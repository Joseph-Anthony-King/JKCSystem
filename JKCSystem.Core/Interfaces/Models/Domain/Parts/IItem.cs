namespace JKCSystem.Core.Interfaces.Models.Domain.Parts
{
    internal interface IItem
    {
        decimal Cost { get; set; }
        decimal SavingsOverMSRP { get; }
        decimal WarrantyCost { get; set; }
        decimal SuggestedPrice { get; }
        decimal Price { get; set; }
        decimal Margin { get; }
    }
}

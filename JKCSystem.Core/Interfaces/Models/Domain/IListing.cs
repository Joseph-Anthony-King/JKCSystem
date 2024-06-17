namespace JKCSystem.Core.Interfaces.Models.Domain
{
    internal interface IListing : IDomainEntity
    {
        string Headline { get; set; }
        ICommercial Platform { get; set; }
        IOrder Order { get; set; }
        string Description { get; set; }
        string Url { get; set; }
    }
}

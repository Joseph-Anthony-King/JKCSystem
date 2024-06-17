namespace JKCSystem.Core.Interfaces.Models.Domain
{
    internal interface IStore : IDomainEntity
    {
        List<IAddress> Addresses { get; set; }
        string Url { get; set; }
        string Phone { get; set; }
        string Email { get; set; }
    }
}

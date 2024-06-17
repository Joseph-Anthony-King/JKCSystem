namespace JKCSystem.Core.Interfaces.Models.Domain
{
    internal interface IAddress : IDatabaseEntry
    {
        string StreetAddress1 { get; set; }
        string StreetAddress2 { get; set; }
        string City { get; set; }
        string State { get; set; }
        string PostalCode { get; set; }
        string Country { get; set; }
        string ToJson();
        IDomainEntity Cast<T>();
    }
}

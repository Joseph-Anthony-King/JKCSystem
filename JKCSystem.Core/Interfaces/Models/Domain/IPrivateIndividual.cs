namespace JKCSystem.Core.Interfaces.Models.Domain
{
    internal interface IPrivateIndividual : IDomainEntity
    {
        string FirstName { get; set; }
        string MiddleName { get; set; }
        string LastName { get; set; }
        List<IAddress> Addresses { get; set; }
        string Phone { get; set; }
        string Cell { get; set; }
        string Email { get; set; }
    }
}

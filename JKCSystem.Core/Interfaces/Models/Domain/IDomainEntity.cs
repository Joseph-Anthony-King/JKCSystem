namespace JKCSystem.Core.Interfaces.Models.Domain
{
    internal interface IDomainEntity : IDatabaseEntry
    {
        string ToJson();
        IDomainEntity Cast<T>();
    }
}

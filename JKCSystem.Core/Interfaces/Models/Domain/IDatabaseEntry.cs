namespace JKCSystem.Core.Interfaces.Models.Domain
{
    internal interface IDatabaseEntry
    {
        int Id { get; set; }
        DateTime DateCreated { get; set; }
        DateTime DateModified { get; set; }
    }
}

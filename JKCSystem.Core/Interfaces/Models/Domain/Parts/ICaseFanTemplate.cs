namespace JKCSystem.Core.Interfaces.Models.Domain.Parts
{
    internal interface ICaseFanTemplate : IPart, ICooler
    {
        string FanController { get; set; }
        string FanThickness { get; set; }
        string LED { get; set; }
    }
}

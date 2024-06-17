namespace JKCSystem.Core.Interfaces.Models.Domain.Parts
{
    internal interface IPowerSupplyTemplate : IPart
    {
        string MaximumPower { get; set; }
        int Fans { get; set; }
        string MainConnector { get; set; }
        string PCIExpressConnector { get; set; }
        string SATAPowerConnector { get; set; }
        string MAXPSULength { get; set; }
        string PowerGoodSignal { get; set; }
        string Efficiency { get; set; }
        string EnergyEfficient { get; set; }
        bool OverVoltageProtection { get; set; }
        bool OverloadProtection { get; set; }
        string PowerRating { get; set; }
    }
}

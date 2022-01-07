using System;

namespace Store.Contracts
{
    public interface IAppliance
    {
        string Model { get; }

        DateTime ProductionDate { get; }

        double Weight { get; }
    }
}

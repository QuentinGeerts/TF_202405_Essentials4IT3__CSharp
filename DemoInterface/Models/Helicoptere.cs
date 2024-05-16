using DemoInterface.Enums;
using DemoInterface.Interfaces;

namespace DemoInterface.Models;

internal class Helicoptere : IVehiculeAerien
{
    public TypeCarburant TypeCarburant { get; set; }
}

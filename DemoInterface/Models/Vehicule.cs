using DemoInterface.Enums;
using DemoInterface.Interfaces;

namespace DemoInterface.Models;

internal abstract class Vehicule : IVehicule
{
    private TypeCarburant _typeCarburant;

    public TypeCarburant TypeCarburant { 
        get => _typeCarburant; 
        set => _typeCarburant = value; 
    }
}

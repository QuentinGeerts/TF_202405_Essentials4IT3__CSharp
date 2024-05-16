using DemoInterface.Interfaces;

namespace DemoInterface.Models;

internal class Moto : Vehicule, IVehiculeTerrestre
{
    public void Rouler()
    {
        Console.WriteLine($"La {GetType().Name} roule...");
    }
}

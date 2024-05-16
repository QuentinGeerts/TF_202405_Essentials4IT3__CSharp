using DemoInterface.Interfaces;

namespace DemoInterface.Models;

internal class Voiture : Vehicule, IVehiculeTerrestre
{
    public void Rouler()
    {
        Console.WriteLine($"La {GetType().Name} roule...");
    }

    public void Tourner()
    {
        Console.WriteLine($"La {GetType().Name} tourne...");
    }
}

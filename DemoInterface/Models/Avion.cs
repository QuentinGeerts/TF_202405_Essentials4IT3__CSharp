using DemoInterface.Interfaces;

namespace DemoInterface.Models;

internal class Avion : Vehicule, IVehiculeAerien
{
    public void Voler()
    {
        Console.WriteLine($"La {GetType().Name} vole...");
    }
}

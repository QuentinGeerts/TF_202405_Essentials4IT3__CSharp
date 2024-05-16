using DemoInterface.Interfaces;

namespace DemoInterface.Models;

internal class Bateau : Vehicule, IVehiculeMaritime
{
    public void Voguer()
    {
        Console.WriteLine($"La {GetType().Name} vogue...");
    }
}

using DemoInterface.Interfaces;

namespace DemoInterface.Models;

internal class SousMarin : Vehicule, IVehiculeMaritime
{
    public void Voguer()
    {
        Console.WriteLine($"La {GetType().Name} vogue...");
    }

    public void Plonger()
    {
        Console.WriteLine($"Le sous-marin plonge...");
    }
}

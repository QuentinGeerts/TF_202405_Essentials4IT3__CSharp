using DemoInterface.Interfaces;

namespace DemoInterface.Models;

internal class VoitureAmphibie : Voiture, IVehiculeMaritime
{
    public void Voguer()
    {
        Console.WriteLine($"La {GetType().Name} vogue...");
    }
}

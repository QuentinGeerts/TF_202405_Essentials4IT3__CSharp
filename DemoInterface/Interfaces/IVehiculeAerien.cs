namespace DemoInterface.Interfaces;

internal interface IVehiculeAerien : IVehicule
{

    // Vous pouvez appliquer un comportement par défaut depuis 
    // quelques versions de C#
    void Voler()
    {
        Console.WriteLine($"Le {GetType().Name} vole...");
    }
}

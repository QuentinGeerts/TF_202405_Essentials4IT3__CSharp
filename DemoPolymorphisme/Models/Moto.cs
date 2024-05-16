namespace DemoPolymorphisme.Models;

internal class Moto : Vehicule
{
    public override int NbRoues { get => 2; }
    public bool aCoffre { get; set; }

}

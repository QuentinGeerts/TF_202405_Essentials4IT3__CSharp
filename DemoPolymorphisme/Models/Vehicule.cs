namespace DemoPolymorphisme.Models;

enum TypeCarburant
{
    Diesel,
    Essence,
    LPG,
    Electrique
}

internal class Vehicule
{
    public virtual int NbRoues { get; set; } = 4;
    public int NbPlaces { get; set; }
    public string Couleur { get; set; }
    public TypeCarburant TypeCarburant { get; set; }
}

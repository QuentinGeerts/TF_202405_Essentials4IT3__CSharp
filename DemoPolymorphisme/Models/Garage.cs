namespace DemoPolymorphisme.Models;

internal class Garage
{
    private readonly List<Vehicule> _vehicules;

    public Garage()
    {
        _vehicules = new List<Vehicule>();
    }

    public void AjouterVehicule (Vehicule vehicule)
    {
        if (vehicule == null) return;
        if (_vehicules.Contains(vehicule)) return;

        _vehicules.Add(vehicule);
    }

    public void FaireEntretien ()
    {
        foreach (var vehicule in _vehicules)
        {
            switch (vehicule)
            {
                case VoitureSport vsE 
                    when vsE.TypeCarburant == TypeCarburant.Electrique :
                    vsE.aTurbo = false;
                    break;

                case VoitureSport vs:
                    vs.Couleur = "Rouge";
                    vs.NbPortes = 3;
                    vs.aTurbo = true;
                    break;

                case Voiture v:
                    v.Couleur = "Grise";
                    v.NbPortes = 5;
                    break;

                case Moto m:
                    m.Couleur = "Bleu";
                    m.aCoffre = true;
                    break;

                default:
                    vehicule.TypeCarburant = TypeCarburant.Diesel;
                    break;
            }

            if (vehicule is Moto m1) 
            {
                m1.aCoffre = false;
            }
            else if (vehicule is VoitureSport vs)
            {
                vs.aTurbo = false;
            }
            else if (vehicule is Voiture v)
            {
                v.NbPortes = 2;
            }
            else
            {
                vehicule.TypeCarburant = TypeCarburant.Diesel;
            }
        }
    }
}

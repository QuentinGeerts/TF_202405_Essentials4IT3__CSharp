using DemoInterface.Interfaces;
using DemoInterface.Models;

VoitureAmphibie va = new VoitureAmphibie();
va.Rouler();
va.Voguer();

Avion avion1 = new Avion();
Avion avion2 = new Avion();

Bateau bateau1 = new Bateau();
Bateau bateau2 = new Bateau();
Bateau bateau3 = new Bateau();

Moto moto1 = new Moto();
Moto moto2 = new Moto();

SousMarin sousMarin = new SousMarin();

Voiture voiture1 = new Voiture();
Voiture voiture2 = new Voiture();
Voiture voiture3 = new Voiture();
Voiture voiture4 = new Voiture();
Voiture voiture5 = new Voiture();
Voiture voiture6 = new Voiture();

VoitureAmphibie voitureAmphibie = new VoitureAmphibie();



Garage garage = new Garage();
garage.AjouterMoyenMotorise(avion1);
garage.AjouterMoyenMotorise(avion2);
garage.AjouterMoyenMotorise(bateau1);
garage.AjouterMoyenMotorise(bateau2);
garage.AjouterMoyenMotorise(bateau3);
garage.AjouterMoyenMotorise(moto1);
garage.AjouterMoyenMotorise(moto2);
garage.AjouterMoyenMotorise(sousMarin);
garage.AjouterMoyenMotorise(voiture1);
garage.AjouterMoyenMotorise(voiture2);
garage.AjouterMoyenMotorise(voiture3);
garage.AjouterMoyenMotorise(voiture4);
garage.AjouterMoyenMotorise(voiture5);
garage.AjouterMoyenMotorise(voiture6);
garage.AjouterMoyenMotorise(voitureAmphibie);

Console.WriteLine($"Vous avez {garage.VehiculesTerrestres.Length} véhicules terrestres");

foreach (IVehiculeTerrestre vehicule in garage.VehiculesTerrestres)
{
	vehicule.Rouler();

	if (vehicule is Voiture voiture) // Pattern matching
	{
		//((Voiture) vehicule).Tourner();
		voiture.Tourner();
	}
}

Console.WriteLine($"Vous avez {garage.VehiculeMaritimes.Length} véhicules maritimes.");

foreach (IVehiculeMaritime vehicule in garage.VehiculeMaritimes)
{
    vehicule.Voguer();

    if (vehicule is SousMarin sm)
	{
		// ((SousMarin)vehicule).Plonger();
		sm.Plonger();
	}
}

Trottinette trottinette = new Trottinette();

garage.AjouterMoyenNonMotorise(trottinette);

Helicoptere helicoptere = new Helicoptere();
((IVehiculeAerien)helicoptere).Voler();
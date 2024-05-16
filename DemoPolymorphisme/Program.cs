using DemoPolymorphisme.Models;

Vehicule vehicule = new Vehicule();
Voiture voiture = new Voiture();
Moto moto = new Moto();
VoitureSport voitureSport = new VoitureSport();


// Possible car une voiture de sport est une voiture
Voiture voiture1 = new VoitureSport();

// Pas possible car une voiture n'est pas forcément une voiture de sport
// VoitureSport voitureSport1 = new Voiture(); 

((VoitureSport) voiture1).aTurbo = false;

Vehicule vehicule1 = new VoitureSport();
((VoitureSport) vehicule1).aTurbo = true;


Garage garage = new Garage();
garage.AjouterVehicule(voiture);
garage.AjouterVehicule(moto);
garage.AjouterVehicule(voitureSport);
garage.AjouterVehicule(vehicule);

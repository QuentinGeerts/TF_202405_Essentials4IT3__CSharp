using DemoAbstract.Models;

// Impossible d'instancier une classe abstraite
// Animal animal = new Animal();
// animal.FaireBruit();

Chien chien = new Chien();
Chat chat = new Chat();
Canard canard = new Canard();

// Appel des fonctions
chien.FaireBruit(); // Le chien fait : Woof !
chien.Dormir(); // L'animal dort.

chat.FaireBruit(); // Le chat fait : meeow !
chat.Dormir(); // L'animal dort.

canard.FaireBruit(); // Le canard fait : coin coiin !
canard.Dormir(); // L'animal dort.

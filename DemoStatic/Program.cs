using DemoStatic.Models;

using static DemoStatic.Models.Utility;

// Impossible de créer une instance d'une classe static
// => Impossible de créer un constructeur dans celle-ci
// Utility utility = new Utility();

Utility.FormatText("Bonjour");
SayHello("Quentin");


Counter counter1 = new Counter();
Counter counter2 = new Counter();
Counter counter3 = new Counter();
Counter counter4 = new Counter();
Counter counter5 = new Counter();
Counter counter6 = new Counter();


Console.WriteLine($"Le compteur vaut : {Counter.Count}");
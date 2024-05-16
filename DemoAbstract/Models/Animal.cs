namespace DemoAbstract.Models;

// Une classe abstraite n'implique pas de rendre ses membres abstraits
internal abstract class Animal
{

    // Une méthode abstraite (sans corps) rend obligatoire sa classe abstraite
    // Redéfinition obligatoire de la méthode dans les sous-classes
    // abstract: vous devez redéfinir
    // virtual : vous pouvez redéfinir
    public abstract void FaireBruit();

    public void Dormir ()
    {
        Console.WriteLine("L'animal dort profondément...");
    }

}

namespace DemoAbstract.Models;

internal class Chien : Animal
{
    // Redéfinition de la méthode abstraite du parent !
    public override void FaireBruit()
    {
        Console.WriteLine("Le chien fait : wooof !");
    }
}

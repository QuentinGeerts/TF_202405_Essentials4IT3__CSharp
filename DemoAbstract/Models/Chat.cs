namespace DemoAbstract.Models;

internal class Chat : Animal
{
    // Redéfinition de la méthode abstraite du parent !
    public override void FaireBruit()
    {
        Console.WriteLine("Le chat fait : meoow !");
    } 
}

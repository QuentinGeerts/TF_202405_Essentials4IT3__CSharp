namespace DemoAbstract.Models;

internal class Canard : Animal
{
    // Redéfinition de la méthode abstraite du parent !
    public override void FaireBruit()
    {
        Console.WriteLine("Le canard fait : Coinn Coiiin !");
    }
}

namespace DemoStatic.Models;

internal static class Utility
{
    // Membre de classe
    public static void FormatText (string text)
    {
        Console.WriteLine($" ---- {text} ---- ");
    }

    // Membre d'instance
    public static void SayHello (string firstName)
    {
        Console.WriteLine($"Hello {firstName}");
    }

    // Classe statique => impossible de créer de constructeur
    //public Utility()  
    //{
        
    //}
}

namespace DemoStatic.Models;

internal class Counter
{
    // Champ static
    private static int _counter;

    // Propriété static
    public static int Count 
    {
        get { return _counter; }
    }

    // Constructeur
    public Counter()
    {
        _counter++;
    }

}

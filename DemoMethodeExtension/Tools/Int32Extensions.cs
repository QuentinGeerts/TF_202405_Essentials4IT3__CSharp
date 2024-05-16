namespace DemoMethodeExtension.Tools;

internal static class Int32Extensions
{

    public static bool IsPrime(this Int32 value)
    {

        if (value < 2) return false;

        for (int diviseur = 2; diviseur <= (int) Math.Sqrt(value); diviseur++)
        {
            if (value % diviseur == 0) return false;
        }

        return true;

    }

}

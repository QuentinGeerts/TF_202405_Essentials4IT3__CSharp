

using DemoMethodeExtension.Tools;

//Int32Extensions tools = new Int32Extensions();

for (int i = 0; i < 100; i++)
{
    // if (tools.IsPrime(i)) 
    if (i.IsPrime())
    {
        Console.WriteLine($"{i}");
    }
}



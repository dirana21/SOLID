using SOLID_I_Interface_Segregation_Princeple.Lib;

namespace SOLID_I_Interface_Sefregation_Princeple.ConsoleLib;

public static class ConsolePrint
{
    private static void Print(string message, double value, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        Console.WriteLine($"{message} - {value}");
        Console.ResetColor();
    }

    public static void PrintPerimeter(IPerimeter figure)
    {
        Print("Периметр", figure.GetPeremiter(), ConsoleColor.Yellow);
    }

    public static void PrintArea(IArea figure)
    {
        Print("Площадь", figure.GetArea(), ConsoleColor.Cyan);
    }
}
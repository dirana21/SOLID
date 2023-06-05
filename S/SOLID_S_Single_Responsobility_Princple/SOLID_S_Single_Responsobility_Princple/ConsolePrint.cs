namespace SOLID_S_Single_Responsobility_Princple;

public static class ConsolePrint
{
    private static void Print(string message, ConsoleColor color = ConsoleColor.White)
    {
        Console.ForegroundColor = color;
        Console.WriteLine(message);
        Console.ResetColor();
    }

    public static void PrintInfo(string message)
    {
        Print(message,ConsoleColor.Blue);
    }

    public static void PrintError(string message)
    {
        Print(message, ConsoleColor.Red);
    }
}
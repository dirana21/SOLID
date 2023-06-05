using SOLID_I_Interface_Segregation_Princeple.Lib;

namespace SOLID_I_Interface_Sefregation_Princeple.ConsoleLib;

public static class FigureProcessor
{
    public static void ProcessFigure(Figure? figure)
    {
        if (figure is not null)
        {
            if (figure is IPerimeter f) ConsolePrint.PrintPerimeter(f);
            if (figure is IArea a) ConsolePrint.PrintArea(a);
        }
    }
}
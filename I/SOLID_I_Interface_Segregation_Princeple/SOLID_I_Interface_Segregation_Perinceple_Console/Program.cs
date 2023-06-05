using SOLID_I_Interface_Sefregation_Princeple.ConsoleLib;
using SOLID_I_Interface_Segregation_Princeple.Lib;

Console.WriteLine("1. Квадрат");
Console.WriteLine("2. Круг");

var select = Console.ReadLine();
Figure? figure = select switch
{
    "1" => new Square(10),
    "2" => new Circle(10),
    _ => null
};

FigureProcessor.ProcessFigure(figure);
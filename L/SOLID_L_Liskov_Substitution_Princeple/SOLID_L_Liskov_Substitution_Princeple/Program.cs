using SOLID_L_Liskov_Subtitution_Princeple_Library;

IFigure _figure;

Console.WriteLine("Выберети тип фигуры");
Console.WriteLine("1. Прямоугольник");
Console.WriteLine("2. Круг");
Console.WriteLine("3. Квадрат");
var select = Console.ReadLine();
switch (select)
{
    case "1":
        Console.WriteLine("Введите размер стороны A: ");
        var sideA = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите размер стороны B: ");
        var sideB = Convert.ToDouble(Console.ReadLine());
        _figure = new Rectangle(sideA,sideB);
        break;
    case "2":
        Console.WriteLine("Введите радиус круга: ");
        var radius = Convert.ToDouble(Console.ReadLine());
        _figure = new Circle(radius);
        break;
    case "3":
        Console.WriteLine("Введите размер стороны: ");
        var side = Convert.ToDouble(Console.ReadLine());
        _figure = new Square(side);
        break;
    default:
        _figure = null;
        break;
}

Print(_figure);

void Print(IFigure figure)
{
    Console.WriteLine($"Площадь = {figure?.CalcArea()}");
    Console.WriteLine($"Периметр = {figure?.CalcPerimeter()}");
}
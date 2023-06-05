namespace SOLID_L_Liskov_Subtitution_Princeple_Library;

public class Circle : IFigure
{
    private readonly double _radius;
    private const double P = 3.14;

    public Circle(double radius)
    {
        _radius = radius;
    }
    public double CalcArea()
    {
        return P * _radius;
    }

    public double CalcPerimeter()
    {
        return 2 * P * _radius;
    }
}
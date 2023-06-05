namespace SOLID_I_Interface_Segregation_Princeple.Lib;

public class Circle : Figure, IArea
{
    private const double P = 3.14;
    private double _radius;

    public Circle(double radius)
    {
        _radius = radius;
    }
    public double GetArea()
    {
        return _radius * _radius * P;
    }
}
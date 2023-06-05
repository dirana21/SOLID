namespace SOLID_I_Interface_Segregation_Princeple.Lib;

public class Square : Figure, IPerimeter, IArea
{
    private double _side;

    public Square(double side)
    {
        _side = side;
    }
    public double GetPeremiter()
    {
        return 4 * _side;
    }

    public double GetArea()
    {
        return _side * _side;
    }
}
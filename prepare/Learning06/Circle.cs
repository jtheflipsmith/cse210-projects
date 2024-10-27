using System.Net.NetworkInformation;

public class Circle : Shape
{
    private double _radius;

    public Circle(string color, double radius)
    : base(color)
    {
        _radius = radius;
    }

    public override double GetArea()
    {
        double circle = Math.PI * _radius * _radius;
        return circle;
    }
}
using System;
using static System.Math;

class Circle : Shape
{
    private double _radius;

    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }
    public override double GetArea()
    {
       double _CircleArea = PI * Pow(_radius, 2);
        return _CircleArea;
    }
}
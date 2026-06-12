using System;

class Rectangle : Shape
{
    private double _length;
    private double _width;

    public Rectangle(string color, double length, double width) : base(color)
    {
        _length = length;
        _width = width;
    }
    public override double GetArea()
    {
       double _RectangleArea = _length * _width;
        return _RectangleArea;
    }
}
using System;

class Square : Shape
{
    private double _side;

    public Square(string color, double side ) : base(color)
    {
        _side = side;
    }
    public override double GetArea()
    {
       double _squareArea = _side * _side;
        return _squareArea;
    }
}
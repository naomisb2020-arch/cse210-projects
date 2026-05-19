using System;
using System.Runtime.CompilerServices;

class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int numerator)
    {
        _top = numerator;
        _bottom = 1;
    }

    public Fraction(int numerator, int denominator)
    {
        _top = numerator;
        _bottom = denominator;
    }

    public string GetFractionString()
    {
        string fraction = $"{_top}/{_bottom}"; 
        return fraction;
    }

    public double GetDecimalValue()
    {
        double decimalValue = (double)_top / (double)_bottom; 
        return decimalValue;
    }

}
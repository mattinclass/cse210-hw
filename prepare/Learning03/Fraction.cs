using System.Collections.Generic;
using System;


public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public Fraction(int integer)
    {
        _top = integer;
        _bottom = 1;
    }
    public string GetFractionString()
    {
        string fractionString = $"{_top}/{_bottom}";
        return fractionString;

    }

    public double GetDecimalValue()
    {
        double decimalValue = (double)_top / (double)_bottom;
        return decimalValue;
    }

}
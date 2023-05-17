using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Fraction myFraction = new Fraction();
        Console.WriteLine(myFraction.GetFractionString());
        Console.WriteLine(myFraction.GetDecimalValue());

        Fraction myFraction1 = new Fraction(7);
        Console.WriteLine(myFraction1.GetFractionString());
        Console.WriteLine(myFraction1.GetDecimalValue());

        Fraction myFraction2 = new Fraction(10, 7);
        Console.WriteLine(myFraction2.GetFractionString());
        Console.WriteLine(myFraction2.GetDecimalValue());
    }
}
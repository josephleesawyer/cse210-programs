using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Fractions Project.");
        Fraction frac1 = new Fraction();
        Fraction frac2 = new Fraction(5);
        Fraction frac3 = new Fraction(3, 4);
        Console.WriteLine($"{frac1.GetFractionString()}, {frac2.GetFractionString()}, {frac3.GetFractionString()}");
        Console.WriteLine($"{frac1.GetDecimalValue()}, {frac2.GetDecimalValue()}, {frac3.GetDecimalValue()}");
    }
}
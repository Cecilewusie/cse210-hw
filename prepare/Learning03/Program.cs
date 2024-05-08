using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction = new Fraction();
        Fraction fraction1 = new Fraction(6);
        Fraction fraction2 = new Fraction(3,4);

        // Console.WriteLine("for first object");
        // fraction.setTop(8);
        // Console.WriteLine(fraction.GetTop());

        // fraction.SetBottom(13);
        // Console.WriteLine(fraction.GetBottom());
        Console.WriteLine(fraction.GetFractionString());
        Console.WriteLine(fraction.GetFractionDecimal());

        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.GetFractionDecimal());

        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction2.GetFractionDecimal());
              
        
    }
}
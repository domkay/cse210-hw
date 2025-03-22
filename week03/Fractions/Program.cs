using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello! This is the Fractions Project.");
        int top, bottom;
        Fraction f1 = new Fraction();
        Console.Write("Enter 'top' number: ");
        top = int.Parse(Console.ReadLine());
        Console.Write("Enter 'bottom' number: ");
        bottom = int.Parse(Console.ReadLine());
        Fraction f2 = new Fraction(top);
        Fraction f3 = new Fraction(top, bottom);

        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue().ToString("F2"));

        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue().ToString("F2"));

        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue().ToString("F2"));

    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");

        // Testing Constructors
        Fraction f1 = new Fraction();          // Defaults to 1/1
        Fraction f2 = new Fraction(5);         // Initialized to 5/1
        Fraction f3 = new Fraction(3, 4);      // Initialized to 3/4
        Fraction f4 = new Fraction(1, 3);      // Initialized to 1/3

        // Displaying representations matching the sample output
        DisplayFractionInfo(f1);
        DisplayFractionInfo(f2);
        DisplayFractionInfo(f3);
        DisplayFractionInfo(f4);

        // Testing Getters and Setters explicitly
        Console.WriteLine("\n--- Testing Getters and Setters ---");
        Fraction customFraction = new Fraction();
        customFraction.SetTop(2);
        customFraction.SetBottom(5);
        
        Console.WriteLine($"New Fraction String: {customFraction.GetFractionString()}");
        Console.WriteLine($"New Decimal Value: {customFraction.GetDecimalValue()}");
    }

    static void DisplayFractionInfo(Fraction f)
    {
        Console.WriteLine(f.GetFractionString());
        Console.WriteLine(f.GetDecimalValue());
    }
}
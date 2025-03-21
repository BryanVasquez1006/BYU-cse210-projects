using System;

class Program
{
    static void Main(string[] args)
    {
        Fractions fraction1 = new Fractions();
        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.GetDecimalValue());

        Fractions fraction2 = new Fractions(3,4);
        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction2.GetDecimalValue());
        //Getting the top and bottom number of the 3/4 fraction
        Console.WriteLine(fraction2.GetTopNum());
        Console.WriteLine(fraction2.GetBottomNum());
;

        
        
    
    }
}
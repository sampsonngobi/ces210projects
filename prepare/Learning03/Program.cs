using System;

class Program
{
    static void Main(string[] args)
    {

        Fraction f1 = new Fraction();

        Console.WriteLine(f1.getFractionString());
        Console.WriteLine(f1.getDecimalValue());

        
        Fraction f2 = new Fraction(5);

        Console.WriteLine(f2.getFractionString());
        Console.WriteLine(f2.getDecimalValue());


        Fraction f3 = new Fraction(3,4);

        Console.WriteLine(f3.getFractionString());
        Console.WriteLine(f3.getDecimalValue());

        Fraction f4 = new Fraction(1,3);

        Console.WriteLine(f4.getFractionString());
        Console.WriteLine(f4.getDecimalValue());



    //     Fraction fraction1 = new Fraction();
    //     Console.WriteLine($"{fraction1.getUpperNumber()} / {fraction1.getLowerNumber()}");
        

    //     double decimalValue1 = fraction1.getDecimalValue(fraction1.getUpperNumber(), fraction1.getLowerNumber());
    //     Console.WriteLine(decimalValue1);

    
    //     Fraction fraction2 = new Fraction();
    //     fraction2.setUpperNumber(5);
    //     Console.WriteLine($"{fraction2.getUpperNumber()} / {fraction2.getLowerNumber()}");

    //     double decimalValue2 = fraction2.getDecimalValue(fraction2.getUpperNumber(), fraction2.getLowerNumber());
    //     Console.WriteLine(decimalValue2);



    //     Fraction fraction3 = new Fraction();
    //     fraction3.setUpperNumber(3);
    //     fraction3.setBottomNumber(4);

    //     Console.WriteLine($"{fraction3.getUpperNumber()} / {fraction3.getLowerNumber()}");

    //     double decimalValue3 = fraction3.getDecimalValue(fraction3.getUpperNumber(), fraction3.getLowerNumber());
    //     Console.WriteLine(decimalValue3);

    //     Fraction fraction4 = new Fraction();
    //     fraction4.setUpperNumber(1);
    //     fraction4.setBottomNumber(3);

    //     Console.WriteLine($"{fraction4.getUpperNumber()} / {fraction4.getLowerNumber()}");

    //     double decimalValue4 = fraction4.getDecimalValue(fraction4.getUpperNumber(), fraction4.getLowerNumber());
    //     Console.WriteLine(decimalValue4);
    }
        

}   


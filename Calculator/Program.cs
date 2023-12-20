using System;

// ICalculator interface

class Program
{
    static void Main()
    {
        Calculator calc = new Calculator();

        double qoshish = calc.Addition(5, 3);
        double ayirish = calc.Subtraction(5, 3);
        double kopaytr = calc.Multiplication(5, 3);
        double bolish = calc.Division(5, 3);

        Console.WriteLine($"Qoshish: {qoshish}");
        Console.WriteLine($"Ayirish: {ayirish}");
        Console.WriteLine($"Kopaytrish: {kopaytr}");
        Console.WriteLine($"Bo'lish: {bolish}");
    }
}
using System;

// ICalculator interface
public interface ICalculator
{
    double Addition(double x, double y);
    double Subtraction(double x, double y);
    double Multiplication(double x, double y);
    double Division(double x, double y);
}

// Calculator class
public class Calculator : ICalculator
{
    public double Addition(double x, double y)
    {
        return x + y;
    }

    public double Subtraction(double x, double y)
    {
        return x - y;
    }

    public double Multiplication(double x, double y)
    {
        return x * y;
    }

    public double Division(double x, double y)
    {
        if (y != 0)
        {
            return x / y;
        }
        else
        {
            throw new ArgumentException("Cannot divide by zero");
        }
    }
}
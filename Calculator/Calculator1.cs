using System;
using System.Numerics;


public interface ICalculator<Generic>
{
    Generic Add(Generic operand1, Generic operand2);
    Generic Subtract(Generic operand1, Generic operand2);
    Generic Multiply(Generic operand1, Generic operand2);
    Generic Divide(Generic operand1, Generic operand2);
}


public class Calculator<Generic> : ICalculator<Generic>
    where Generic : INumber<Generic>
{
    public Generic Add(Generic operand1, Generic operand2)
    {
        
        return operand1 + operand2;
    }

    public Generic Subtract(Generic operand1, Generic operand2)
    {
        Generic value1 = operand1;
        Generic value2 = operand2;
        return value1 - value2;
    }

    public Generic Multiply(Generic operand1, Generic operand2)
    {
        Generic value1 = operand1;
        Generic value2 = operand2;
        return value1 * value2;
    }


    public Generic Divide(Generic operand1, Generic operand2)
    {
        Generic value1 = operand1;
        Generic value2 = operand2;

       

        return value1 / value2;
    }

   

   
}

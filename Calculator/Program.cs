class Program
{
    static void Main()
    {
        
        Calculator<int> intCalculator = new Calculator<int>();
        Console.WriteLine(intCalculator.Add(5, 3));      
        Console.WriteLine(intCalculator.Subtract(7, 2)); 
        Console.WriteLine(intCalculator.Multiply(4, 6));  
        Console.WriteLine(intCalculator.Divide(8, 2));   

    
    }
}


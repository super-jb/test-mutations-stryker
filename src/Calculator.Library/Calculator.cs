namespace Calculator.Library;

public class Calculator
{
    public static long Add(int a, int b)
    {
        return a + b; 
    }

    public static int Subtract(int a, int b)
    {
        return a - b;
    }

    public static long Multiply(int a, int b)
    {
        return a * b;
    }

    public static (int Result, int Remainder) Divide(int a, int b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("Go back to school!");
        }
        
        var result = a / b;
        var remainder = a % b;
        return (result, remainder);
    }
}
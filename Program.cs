namespace Labs5;

class Program
{
    public static float GetIntegralValue(float value)
    {
        return (1 + value) / (2 + 3 * value) / (2 + 3 * value);
    } 
    static void Main(string[] args)
    {
        float leftBorder = 1;
        float rightBorder = 3;
        float e1 = 0.01f;
        float e2 = 0.001f;
        Console.WriteLine("Метод левых прямоугольников");
        RungeRule leftRectangle = new RungeRule(new LeftRectangleMethod(GetIntegralValue), 1);
        Console.WriteLine(leftRectangle.SolveIntegral(leftBorder,rightBorder,e1));
        Console.WriteLine(leftRectangle.SolveIntegral(leftBorder,rightBorder,e2)); 
        Console.WriteLine("Метод трапеции");
        RungeRule trapezoid = new RungeRule(new TrapezoidMethod(GetIntegralValue), 2);
        Console.WriteLine(trapezoid.SolveIntegral(leftBorder,rightBorder,e1));
        Console.WriteLine(trapezoid.SolveIntegral(leftBorder,rightBorder,e2)); 
        Console.WriteLine("Метод 4го порядка");
        RungeRule forthOrder = new RungeRule(new ForthOrderMethod(GetIntegralValue), 6);
        Console.WriteLine(forthOrder.SolveIntegral(leftBorder,rightBorder,e1));
        Console.WriteLine(forthOrder.SolveIntegral(leftBorder,rightBorder,e2)); 
        
        
    }
}
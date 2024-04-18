namespace Labs5;

public class LeftRectangleMethod:IIntegralSolver
{
    private IntegralFunction _function;

    public LeftRectangleMethod(IntegralFunction function)
    {
        _function = function;
    }

    public float Solve(float leftBorder, float rightBorder, float step)
    {
        float integralValue = 0;
        for (float i = leftBorder; i <= rightBorder; i+=step)
        {
            integralValue += step * _function(i);
        }
        return integralValue;
    }
}
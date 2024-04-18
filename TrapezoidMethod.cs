namespace Labs5;

public class TrapezoidMethod:IIntegralSolver
{
    private IntegralFunction _function;

    public TrapezoidMethod(IntegralFunction function)
    {
        _function = function;
    }

    public float Solve(float leftBorder, float rightBorder, float step)
    {
        float integralValue = 0;
        for (float i = leftBorder+step; i < rightBorder; i += step)
        {
            integralValue += _function(i);
        }
        integralValue *= 2;
        integralValue += _function(leftBorder);
        integralValue += _function(rightBorder);
        integralValue = integralValue * step / 2;
        return integralValue;
    }
}
namespace Labs5;

public class ForthOrderMethod:IIntegralSolver
{
    private IntegralFunction _function;
    private float[] _index = new[] { 7f, 32f, 12f, 32f, 7f };
    private float _c = 2f / 45f;
    public ForthOrderMethod(IntegralFunction function)
    {
        _function = function;
    }

    public float Solve(float leftBorder, float rightBorder, float step)
    {
        float integralValue = 0;
        for (float i = leftBorder; i <= rightBorder-(4*step); i += 4*step)
        {
            for (int j = 0; j < _index.Length; j++)
            {
                integralValue +=_index[j]*_function(i+j*step);
            }
        }
        
        integralValue = integralValue * step *_c;
        return integralValue;
    }
}
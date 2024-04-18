namespace Labs5;

public class RungeRule
{
    private int _orderOfAccuracy;
    private int _step;
    private int _r;
    private IIntegralSolver _solver;

    public RungeRule(IIntegralSolver solver, int orderOfAccuracy, int step = 2, int r = 2)
    {
        _orderOfAccuracy = orderOfAccuracy;
        _solver = solver;
        _step = step;
        _r = r;
    }

    public (float,float) SolveIntegral(float leftBorder, float rightBorder, float accuracy)
    {
        int step = _step;
        float h = (rightBorder - leftBorder) / step;
        float oldValue = _solver.Solve(leftBorder, rightBorder, h);
        while (true)
        {
            int newStepNumber = step * _r;
            float newH = (rightBorder - leftBorder) / newStepNumber;
            float newValue = _solver.Solve(leftBorder, rightBorder,newH);
            if (_orderOfAccuracy!=0&&Math.Abs(oldValue - newValue) / (Math.Pow(_r, _orderOfAccuracy) - 1) < accuracy) return (newValue, newH);
            else if(Math.Abs(oldValue - newValue) < accuracy) return (newValue, newH);
            else
            {
                step = newStepNumber;
                oldValue = newValue;
            }
        }
    }
}
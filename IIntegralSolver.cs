namespace Labs5;

public delegate float IntegralFunction(float value);
public interface IIntegralSolver
{
    public float Solve(float leftBorder, float rightBorder, float step);
}
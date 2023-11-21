namespace Slomerr.ShapeCalculator.Exceptions;

public sealed class NegativeOrZeroRadiusException : Exception
{
    public NegativeOrZeroRadiusException() : base("Radius of circle most be greater than zero")
    {
    }
}
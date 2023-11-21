using System.Runtime.CompilerServices;
using Slomerr.ShapeCalculator.Exceptions;

namespace Slomerr.ShapeCalculator.Calculation;

internal sealed class Calculator : IShapeCalculator
{
    private readonly Dictionary<Type,ICalculationModule> _modules;

    public Calculator(Dictionary<Type, ICalculationModule> modules)
    {
        _modules = modules;
    }
    
    public double GetSquare<TShape>(ref TShape shape) where TShape : IShape
    {
        if (_modules.TryGetValue(typeof(TShape), out var module))
        {
            return module.GetSquare(ref shape);
        }

        throw new NotFoundCalculationModuleException(shape.GetType().Name);
    }
}
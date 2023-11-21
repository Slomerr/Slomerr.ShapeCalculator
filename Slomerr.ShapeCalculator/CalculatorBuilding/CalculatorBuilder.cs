using Slomerr.ShapeCalculator.Calculation;
using Slomerr.ShapeCalculator.DefaultCalculationModules;
using Slomerr.ShapeCalculator.DefaultShapes;
using Slomerr.ShapeCalculator.Exceptions;

namespace Slomerr.ShapeCalculator.CalculatorBuilding;

public sealed class CalculatorBuilder
{
    public static CalculatorBuilder GetBuilder() => new CalculatorBuilder();

    public static CalculatorBuilder GetDefaultBuilder()
    {
        var builder = GetBuilder();
        builder.AddDefaultModules();
        return builder;
    }

    public CalculatorBuilder AddCalculationModule<TShape, TModule>() 
        where TShape : IShape 
        where TModule : ICalculationModule
    {
        _moduleSchemas.Add(new ModuleSchema(
            Shape: typeof(TShape),
            CalculationModule: typeof(TModule)));
        return this;
    }

    public CalculatorBuilder AddDefaultModules()
    {
        AddCalculationModule<Circle, CircleCalculationModule>();
        AddCalculationModule<Triangle, TriangleCalculationModule>();
        return this;
    }

    public IShapeCalculator Build()
    {
        var map = new Dictionary<Type, ICalculationModule>();
        foreach (var schema in _moduleSchemas)
        {
            if (map.ContainsKey(schema.Shape))
            {
                throw new ModuleIsAlreadyExistException(schema.Shape.Name);
            }

            map.Add(schema.Shape, (ICalculationModule)Activator.CreateInstance(schema.CalculationModule)!);
        }
        
        return new Calculator(map);
    }

    private List<ModuleSchema> _moduleSchemas = new ();
}
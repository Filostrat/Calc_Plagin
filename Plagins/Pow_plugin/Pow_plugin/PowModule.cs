using Autofac;
using Interfaces;

[assembly: CalcPlugin]

namespace Pow;

public class Pow : ICalcAction
{
    public string Description => "x ^ y";

    public double Execute(double a, double b)
    {
        return Math.Pow(a, b);
    }
}
public class PowModule : Module 
{
    protected override void Load(ContainerBuilder builder)
    {
        builder.RegisterType<Pow>().As<ICalcAction>();
        base.Load(builder);
    }
}


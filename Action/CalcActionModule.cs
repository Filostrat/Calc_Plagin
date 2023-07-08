using Autofac;
using Interfaces;

namespace Action
{
    public class CalcActionModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder containerBuilde)
        {
            containerBuilde.RegisterType<Plus>().As<ICalcAction>();
            containerBuilde.RegisterType<Divide>().As<ICalcAction>();
            containerBuilde.RegisterType<Minus>().As<ICalcAction>();
            containerBuilde.RegisterType<Multiply>().As<ICalcAction>();
            base.Load(containerBuilde);
        }
    }
}
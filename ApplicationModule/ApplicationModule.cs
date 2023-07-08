using Autofac;

namespace Application
{
    public class ApplicationModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder containerBuilde)
        {
            containerBuilde.RegisterType<CalculatorApp>().As<IApplication>();

            base.Load(containerBuilde);
        }
    }
}

using Autofac;
using Lesson6_Calc_plagin_;
using Lesson6_Calc_plagin_.Actions;
using Lesson6_Calc_plagin_.Application;

var loader = new Loader();
var container = loader.BuildContainer();
var app = container.Resolve<CalculatorApp>();
app.Do();



public class Loader 
{
    public IContainer BuildContainer()
    {
        var container = new ContainerBuilder();
        container.RegisterModule<ApplicationModule>();
        container.RegisterModule<CalcActionModule>();



        return containerBuilde.Build();
    }
}


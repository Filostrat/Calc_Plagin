
using Autofac;
using Lesson6_Calc_plagin_;


var loader = new Loader();
var container = loader.BuildContainer();
var app = container.Resolve<CalculatorApp>();
app.Do();



public class Loader 
{
    public IContainer BuildContainer()
    {
        

       

        return containerBuilde.Build();
    }
}


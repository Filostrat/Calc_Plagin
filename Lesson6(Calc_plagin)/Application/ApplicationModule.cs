using Autofac;
using Lesson6_Calc_plagin_.Actions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6_Calc_plagin_.Application
{
    internal class ApplicationModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder containerBuilde)
        {
            containerBuilde.RegisterType<CalculatorApp>().AsSelf();

            base.Load(containerBuilde);
        }
    }
}

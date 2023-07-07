using Autofac;
using Autofac.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6_Calc_plagin_.Actions
{
    internal class CalcActionModule : Autofac.Module
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

using Lesson6_Calc_plagin_.Actions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6_Calc_plagin_.Application
{
    internal class CalculatorApp
    {
        private readonly ICalcAction[] _actions;

        public CalculatorApp(params ICalcAction[] actions)
        {
            _actions = actions;

        }

        public void Do()
        {
            var needContinue = true;
            do
            {
                for (int i = 0; i < _actions.Length; i++)
                {
                    Console.WriteLine($"{i + 1}.{_actions[i].Description}");
                }

                var @operator = int.Parse(Console.ReadLine()!);
                var a = double.Parse(Console.ReadLine()!);
                var b = double.Parse(Console.ReadLine()!);

                if (@operator > _actions.Length || @operator <= 0)
                {
                    throw new ApplicationException("Operator is not supported");
                }

                var result = _actions[@operator - 1].Execute(a, b);

                Console.WriteLine(result);
                Console.WriteLine("Calc smth else ?");
                needContinue = Console.ReadLine()?.ToLowerInvariant() is "yes";

            } while (needContinue);
        }
    }
}

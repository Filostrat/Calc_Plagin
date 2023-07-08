using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface ICalcAction
    {
        public string Description { get; }
        public double Execute(double a, double b);
    }
    public class Divide : ICalcAction
    {
        public string Description => "x / y";

        public double Execute(double a, double b)
        {
            return a / b;
        }
    }
    public class Minus : ICalcAction
    {
        public string Description => "x - y";

        public double Execute(double a, double b)
        {
            return a - b;
        }
    }
    public class Plus : ICalcAction
    {
        public string Description => "x + y";

        public double Execute(double a, double b)
        {
            return a + b;
        }
    }
    public class Multiply : ICalcAction
    {
        public string Description => "x * y";

        public double Execute(double a, double b)
        {
            return a * b;
        }
    }
}

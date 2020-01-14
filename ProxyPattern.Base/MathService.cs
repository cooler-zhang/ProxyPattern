using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern.Base
{
    public class MathService : IMathService
    {
        public double Add(double a, double b)
        {
            return a + b;
        }
    }
}
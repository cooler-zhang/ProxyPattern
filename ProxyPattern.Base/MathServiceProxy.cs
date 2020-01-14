using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern.Base
{
    public class MathServiceProxy : IMathService
    {
        private readonly IMathService _mathService;

        public MathServiceProxy()
        {
            _mathService = new MathService();
        }

        public double Add(double a, double b)
        {
            return _mathService.Add(a, b);
        }
    }
}
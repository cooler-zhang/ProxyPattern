using ProxyPattern.ServiceInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ProxyPattern.Service
{
    public class MathService : IMathService
    {
        public double Add(double a, double b)
        {
            return a + b;
        }
    }
}
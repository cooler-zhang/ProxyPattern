using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ProxyPattern.Base
{
    public interface IMathService
    {
        double Add(double a, double b);
    }
}
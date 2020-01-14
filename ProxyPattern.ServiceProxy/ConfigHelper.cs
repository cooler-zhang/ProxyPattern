using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern.ServiceProxy
{
    public class ConfigHelper
    {
        public static string MathServiceUrl => ConfigurationManager.AppSettings["MathService"];
    }
}
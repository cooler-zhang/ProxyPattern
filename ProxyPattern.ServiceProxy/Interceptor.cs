using Castle.DynamicProxy;
using ProxyPattern.ServiceInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern.ServiceProxy
{
    public class Interceptor<TInterface> : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            Console.WriteLine("Begin Call");
            invocation.Proceed();
            Console.WriteLine($"Result: {invocation.ReturnValue.ToString()}");
        }
    }
}
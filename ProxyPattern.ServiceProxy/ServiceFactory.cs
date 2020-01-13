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
    public class ServiceFactory
    {
        public static TInterface CreateService<TInterface>()
            where TInterface : class
        {
            var generator = new ProxyGenerator();
            return generator.CreateInterfaceProxyWithTargetInterface(CreateInterfaceProxy<TInterface>(), new DynamicServiceInterceptor<TInterface>());
        }

        private static TInterface CreateInterfaceProxy<TInterface>()
            where TInterface : class
        {
            var address = new EndpointAddress("http://localhost:53422/MathService.svc");
            var bind = new BasicHttpBinding();
            var factory = new ChannelFactory<TInterface>(bind, address);
            return factory.CreateChannel();
        }
    }
}
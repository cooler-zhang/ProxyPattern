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
            return generator.CreateInterfaceProxyWithTargetInterface(CreateInterfaceProxy<TInterface>(), new Interceptor<TInterface>());
        }

        private static TInterface CreateInterfaceProxy<TInterface>()
            where TInterface : class
        {
            var address = new EndpointAddress(GetServiceUrl<TInterface>());
            var bind = new BasicHttpBinding();
            var factory = new ChannelFactory<TInterface>(bind, address);
            return factory.CreateChannel();
        }

        public static string GetServiceUrl<TInterface>()
            where TInterface : class
        {
            if (typeof(TInterface) == typeof(IMathService))
                return ConfigHelper.MathServiceUrl;
            throw new NotImplementedException($"{typeof(TInterface)} does not config service url.");
        }
    }
}
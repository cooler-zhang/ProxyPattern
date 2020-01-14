using ProxyPattern.ServiceInterface;
using ProxyPattern.ServiceProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //TestCallService();
            //TestProxyCallService();
            TestDynamicService();
            Console.ReadLine();
        }

        public static void TestCallService()
        {
            var address = new EndpointAddress(ConfigHelper.MathServiceUrl);
            var bind = new BasicHttpBinding();
            var factory = new ChannelFactory<IMathService>(bind, address);
            var channel = factory.CreateChannel();
            var result = channel.Add(1, 2);
            Console.WriteLine($"Result: {result}");
        }

        public static void TestProxyCallService()
        {
            var service = new MathServiceProxy();
            var result = service.Add(1, 2);
            Console.WriteLine($"Result: {result}");
        }

        public static void TestDynamicService()
        {
            var service = ServiceFactory.CreateService<IMathService>();
            var result = service.Add(1, 2);
            var result2 = service.Add(3, 4);
        }
    }
}